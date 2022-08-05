using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Xplore.Models;

namespace Xplore.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class XploreDbContext :
    AbpDbContext<XploreDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    // App Models 
    public virtual DbSet<Enumeration> Enumeration { get; set; }
    public virtual DbSet<Guide> Guides { get; set; }
    public virtual DbSet<Image> Images { get; set; }
    public virtual DbSet<Location> Locations { get; set; }
    public virtual DbSet<Price> Prices { get; set; }
    public virtual DbSet<Rating> Ratings { get; set; }
    public virtual DbSet<Review> Reviews { get; set; }
    public virtual DbSet<ScheduledTrip> ScheduledTrips { get; set; }
    public virtual DbSet<SubscribeAt> SubscribeAts { get; set; }
    public virtual DbSet<Tourist> Tourists { get; set; }
    public virtual DbSet<Trip> Trips { get; set; }
    public virtual DbSet<WishList> WishLists { get; set; }

    #endregion

    public XploreDbContext(DbContextOptions<XploreDbContext> options)
        : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();
        /* Include modules to your migration db context */



      

        /* Configure your own tables/entities inside here */

        // builder.Entity<YourEntity>(b =>
        // {
        //    b.ToTable(XploreConsts.DbTablePrefix + XploreConsts.DbTablePrefix + "YourEntities", XploreConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        // });
 

        builder.Entity<Enumeration>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Enumeration");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);
                entity.ConfigureByConvention();
            });

            builder.Entity<Guide>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Guide");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Firstname).HasMaxLength(255);

                entity.Property(e => e.Lastname).HasMaxLength(255);
                entity.ConfigureByConvention();
            });

            builder.Entity<Image>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Image");

                entity.Property(e => e.Id).ValueGeneratedNever(); 
                entity.HasOne(e=>e.Trip).WithMany(e=>e.Images)
                        .HasForeignKey(p => p.TripId);
                entity.ConfigureByConvention();
            });

            builder.Entity<Location>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Location");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GpsLocation).HasMaxLength(255); 

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.HasOne(e=>e.Trip).WithMany(e=>e.Locations)
                        .HasForeignKey(p => p.TripId);
 
                entity.ConfigureByConvention();
            });

            builder.Entity<Price>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Price");

                entity.Property(e => e.Id).ValueGeneratedNever();
 

                entity.Property(e => e.Value)
                    .HasPrecision(10, 2)
                    .HasColumnName("Value");
                    
                entity.HasOne(e=>e.ScheduledTrip).WithMany(e=>e.Prices)
                        .HasForeignKey(p => p.ScheduledTripId);

                entity.ConfigureByConvention();
            });

            builder.Entity<Rating>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Rating");

                entity.Property(e => e.Id).ValueGeneratedNever();
 

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);
                
                entity.HasOne(e=>e.Review).WithMany(e=>e.Ratings)
                        .HasForeignKey(p => p.ReviewId);

                entity.ConfigureByConvention();
            });

            builder.Entity<Review>(entity =>
            { 
                entity.ToTable(XploreConsts.DbTablePrefix + "Review");
 

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Comment).HasMaxLength(2550);
  

                entity.HasOne(e=>e.ScheduledTrip).WithMany(e=>e.Reviews)
                        .HasForeignKey(p => p.ScheduledTripId);

                entity.HasOne(e=>e.Tourist).WithMany(e=>e.Reviews)
                        .HasForeignKey(p => p.TouristId);


                entity.ConfigureByConvention();
            });

            builder.Entity<ScheduledTrip>(entity =>
            { 

                entity.ToTable(XploreConsts.DbTablePrefix + "ScheduledTrip"); 

                entity.Property(e => e.Id).ValueGeneratedNever();
                //one-to-many relationship with Trip table

                // entity.HasOne<Trip>().WithMany().HasForeignKey(x=>x.TripId).IsRequired(); 
                
                entity.HasOne(e=>e.Trip).WithMany(e=>e.ScheduledTrips)
                        .HasForeignKey(p => p.TripId);

                entity.ConfigureByConvention();
            });

            builder.Entity<SubscribeAt>(entity =>
            {  
                entity.ToTable(XploreConsts.DbTablePrefix + "SubscribeAt");
                entity.HasKey(x=>new{x.ScheduledTripId,x.TouristId}); 
                entity.ConfigureByConvention();
            });

            builder.Entity<Tourist>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Tourist");

                entity.Property(e => e.Id).ValueGeneratedNever();
 

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Firstname).HasMaxLength(255);

                entity.Property(e => e.Lastname).HasMaxLength(255);
                entity.ConfigureByConvention();
            });

            builder.Entity<Trip>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Trip");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Activities).HasMaxLength(255);

                entity.Property(e => e.Agency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255); 

                entity.Property(e => e.DurationUnit).HasMaxLength(255);

                entity.Property(e => e.Glanguages)
                    .HasMaxLength(255)
                    .HasColumnName("GLanguages");

                entity.Property(e => e.IdAchived).HasMaxLength(255);

                entity.Property(e => e.IncludedStuff).HasMaxLength(255);

                entity.Property(e => e.Loging).HasMaxLength(255);

                entity.Property(e => e.NotAllowedStuff).HasMaxLength(255);

                entity.Property(e => e.NotSuitableFor).HasMaxLength(255);

                entity.Property(e => e.Rating).HasMaxLength(255);

                entity.Property(e => e.RequiredStuff).HasMaxLength(255);

                entity.Property(e => e.Risks).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
                entity.ConfigureByConvention();
            });

            builder.Entity<WishList>(entity =>
            { 
                entity.ToTable(XploreConsts.DbTablePrefix + "WishList");

                entity.HasKey(x=>new{x.TripId,x.TouristId}); 
                entity.ConfigureByConvention();
            });


    }
}
