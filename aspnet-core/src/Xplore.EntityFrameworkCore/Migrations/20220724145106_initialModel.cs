using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xplore.Migrations
{
    public partial class initialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Xplore.Activity");

            migrationBuilder.DropTable(
                name: "Xplore.Avoid");

            migrationBuilder.DropTable(
                name: "Xplore.Bring");

            migrationBuilder.DropTable(
                name: "Xplore.EnchargeOf");

            migrationBuilder.DropTable(
                name: "Xplore.Include");

            migrationBuilder.DropTable(
                name: "Xplore.NotAllowedStuff");

            migrationBuilder.DropTable(
                name: "Xplore.Place");

            migrationBuilder.DropTable(
                name: "Xplore.SubscribedTo");

            migrationBuilder.DropTable(
                name: "Xplore.ToBringStuff");

            migrationBuilder.DropTable(
                name: "Xplore.TripInclude");

            migrationBuilder.DropTable(
                name: "Xplore.TripNotSuitableFor");

            migrationBuilder.DropTable(
                name: "Xplore.Warning");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "Xplore.WishList");

            migrationBuilder.DropColumn(
                name: "IsAchived",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "IdTourist",
                table: "Xplore.Rating");

            migrationBuilder.DropColumn(
                name: "IdTrip",
                table: "Xplore.Rating");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Xplore.Guide");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Xplore.Guide");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "Xplore.Guide");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Xplore.Guide");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Xplore.Rating",
                newName: "Value");

            migrationBuilder.AlterColumn<string>(
                name: "IdTrip",
                table: "Xplore.WishList",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdTourist",
                table: "Xplore.WishList",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<double>(
                name: "TripSize",
                table: "Xplore.Trip",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartingTime",
                table: "Xplore.Trip",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DurationUnit",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "Activities",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdAchived",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncludedStuff",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Loging",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NotAllowedStuff",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NotSuitableFor",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredStuff",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Risks",
                table: "Xplore.Trip",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Xplore.Tourist",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdTrip",
                table: "Xplore.SubscribeAt",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdTourist",
                table: "Xplore.SubscribeAt",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Xplore.Review",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdTrip",
                table: "Xplore.Review",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdTourist",
                table: "Xplore.Review",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdComment",
                table: "Xplore.Review",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Xplore.Review",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Xplore.Rating",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "IdReview",
                table: "Xplore.Rating",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdTrip",
                table: "Xplore.Price",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "Review_pkey",
                table: "Xplore.Review",
                column: "IdTourist");

            migrationBuilder.CreateTable(
                name: "Xplore.Enumeration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Type = table.Column<string>(type: "character varying", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.Enumeration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdTrip = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    GpsLocation = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IdTrip = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Type = table.Column<int>(type: "integer", maxLength: 255, nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Schedule",
                columns: table => new
                {
                    IdTrip = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IdGuide = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Xplore.Enumeration");

            migrationBuilder.DropTable(
                name: "Xplore.Image");

            migrationBuilder.DropTable(
                name: "Xplore.Location");

            migrationBuilder.DropTable(
                name: "Xplore.Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "Review_pkey",
                table: "Xplore.Review");

            migrationBuilder.DropColumn(
                name: "Activities",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "IdAchived",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "IncludedStuff",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "Loging",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "NotAllowedStuff",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "NotSuitableFor",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "RequiredStuff",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "Risks",
                table: "Xplore.Trip");

            migrationBuilder.DropColumn(
                name: "IdReview",
                table: "Xplore.Rating");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Xplore.Rating",
                newName: "Rating");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTrip",
                table: "Xplore.WishList",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTourist",
                table: "Xplore.WishList",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Xplore.WishList",
                type: "character varying(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Xplore.WishList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Xplore.WishList",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "Xplore.WishList",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Xplore.WishList",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Xplore.WishList",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Xplore.WishList",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Xplore.WishList",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Xplore.WishList",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "Xplore.WishList",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TripSize",
                table: "Xplore.Trip",
                type: "integer",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartingTime",
                table: "Xplore.Trip",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Xplore.Trip",
                type: "integer",
                maxLength: 255,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DurationUnit",
                table: "Xplore.Trip",
                type: "integer",
                maxLength: 255,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Xplore.Trip",
                type: "integer",
                maxLength: 255,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAchived",
                table: "Xplore.Trip",
                type: "boolean",
                maxLength: 255,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Xplore.Tourist",
                type: "integer",
                maxLength: 255,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTrip",
                table: "Xplore.SubscribeAt",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTourist",
                table: "Xplore.SubscribeAt",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Xplore.Review",
                type: "integer",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTrip",
                table: "Xplore.Review",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdComment",
                table: "Xplore.Review",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Xplore.Review",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTourist",
                table: "Xplore.Review",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Xplore.Rating",
                type: "integer",
                maxLength: 255,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdTourist",
                table: "Xplore.Rating",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdTrip",
                table: "Xplore.Rating",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTrip",
                table: "Xplore.Price",
                type: "uuid",
                maxLength: 255,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Xplore.Guide",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Xplore.Guide",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "Xplore.Guide",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Xplore.Guide",
                type: "integer",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Xplore.Activity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DisplayAr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayEn = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayFr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Tools = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.Activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Avoid",
                columns: table => new
                {
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdStuff = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Bring",
                columns: table => new
                {
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdStuff = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Xplore.EnchargeOf",
                columns: table => new
                {
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdGuide = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Include",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DisplayAr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayEn = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayFr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.Include", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.NotAllowedStuff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DisplayAr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayEn = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayFr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.NotAllowedStuff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Place",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    GpsLocation = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<int>(type: "integer", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.Place", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.SubscribedTo",
                columns: table => new
                {
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdTouriste = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Xplore.ToBringStuff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DisplayAr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayEn = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayFr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.ToBringStuff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xplore.TripInclude",
                columns: table => new
                {
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdInclude = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Xplore.TripNotSuitableFor",
                columns: table => new
                {
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdTrip = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IdWarning = table.Column<Guid>(type: "uuid", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Xplore.Warning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DisplayAr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayEn = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DisplayFr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xplore.Warning", x => x.Id);
                });
        }
    }
}
