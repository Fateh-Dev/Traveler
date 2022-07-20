using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
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
     public  DbSet<Activity> Activities { get; set; }
        public  DbSet<Avoid> Avoids { get; set; }
        public  DbSet<Bring> Brings { get; set; }
        public  DbSet<Comment> Comments { get; set; }
        public  DbSet<EnchargeOf> EnchargeOfs { get; set; }
        public  DbSet<Guide> Guides { get; set; }
        public  DbSet<Include> Includes { get; set; }
        public  DbSet<NotAllowedStuff> NotAllowedStuffs { get; set; }
        public  DbSet<Place> Places { get; set; }
        public  DbSet<Price> Prices { get; set; } 
        public  DbSet<Rating> Ratings { get; set; }
        public  DbSet<Review> Reviews { get; set; }
        public  DbSet<SubscribeAt> SubscribeAts { get; set; }
        public  DbSet<SubscribedTo> SubscribedTos { get; set; }
        public  DbSet<ToBringStuff> ToBringStuffs { get; set; }
        public  DbSet<Tourist> Tourists { get; set; }
        public  DbSet<Trip> Trips { get; set; }
        public  DbSet<TripInclude> TripIncludes { get; set; }
        public  DbSet<TripNotSuitableFor> TripNotSuitableFors { get; set; }
        // public  DbSet<Type> Types { get; set; }
        public  DbSet<Warning> Warnings { get; set; }
        public  DbSet<WishList> WishLists { get; set; }

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

            builder.Entity<Activity>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Activity");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Tools).HasMaxLength(255);
            });

            builder.Entity<Avoid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "Avoid");

                entity.Property(e => e.IdStuff).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);
            });

            builder.Entity<Bring>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "Bring");

                entity.Property(e => e.IdStuff).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);
            });

            builder.Entity<Comment>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Comment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            builder.Entity<EnchargeOf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "EnchargeOf");

                entity.Property(e => e.IdGuide).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);
            });

            builder.Entity<Guide>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Guide");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Firstname).HasMaxLength(255);

                entity.Property(e => e.Languages).HasMaxLength(255);

                entity.Property(e => e.Lastname).HasMaxLength(255);

                entity.Property(e => e.Rating).HasMaxLength(255);
            });

            builder.Entity<Include>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Include");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            builder.Entity<NotAllowedStuff>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "NotAllowedStuff");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            builder.Entity<Place>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Place");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GpsLocation).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            builder.Entity<Price>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Price");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdTrip).HasMaxLength(255);

                entity.Property(e => e.Price1)
                    .HasPrecision(10, 2)
                    .HasColumnName("Price");
            });

            
       builder.Entity<Rating>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Rating");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdTourist).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("Rating");

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            builder.Entity<Review>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "Review");

                entity.Property(e => e.IdComment).HasMaxLength(255);

                entity.Property(e => e.IdTourist).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);

                entity.Property(e => e.Rating).HasMaxLength(255);

                
            });

            builder.Entity<SubscribeAt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "SubscribeAt");

                entity.Property(e => e.IdTourist).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);
            });

            builder.Entity<SubscribedTo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "SubscribedTo");

                entity.Property(e => e.IdTouriste).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);
            });

            builder.Entity<ToBringStuff>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "ToBringStuff");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            builder.Entity<Tourist>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Tourist");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Age).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Firstname).HasMaxLength(255);

                entity.Property(e => e.Lastname).HasMaxLength(255);
            });

            builder.Entity<Trip>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Trip");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Agency).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Duration).HasMaxLength(255);

                entity.Property(e => e.DurationUnit).HasMaxLength(255);

                entity.Property(e => e.Glanguages)
                    .HasMaxLength(255)
                    .HasColumnName("GLanguages");

                entity.Property(e => e.IsAchived).HasMaxLength(255);

                entity.Property(e => e.Rating).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            builder.Entity<TripInclude>(entity =>

            {
                
                entity.ToTable(XploreConsts.DbTablePrefix + "TripInclude");
                entity.HasNoKey();

                entity.Property(e => e.IdInclude).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);
            });

            builder.Entity<TripNotSuitableFor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "TripNotSuitableFor");

                entity.Property(e => e.IdTrip).HasMaxLength(255);

                entity.Property(e => e.IdWarning).HasMaxLength(255);
            });

            builder.Entity<Warning>(entity =>
            {
                entity.ToTable(XploreConsts.DbTablePrefix + "Warning");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            builder.Entity<WishList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable(XploreConsts.DbTablePrefix + "WishList");

                entity.Property(e => e.IdTourist).HasMaxLength(255);

                entity.Property(e => e.IdTrip).HasMaxLength(255);
            });

      

        /* Configure your own tables/entities inside here */

        // builder.Entity<YourEntity>(b =>
        // {
        //    b.ToTable(XploreConsts.DbTablePrefix + "YourEntities", XploreConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        // });
    }
}
