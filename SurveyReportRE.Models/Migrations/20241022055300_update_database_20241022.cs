using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class update_database_20241022 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WordingTypeId",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ClientTypeId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ConstructionBuildingId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ConstructionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ExposureId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "HoREOpinionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LineOfBusinessId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LossHistoryId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ManagementId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "NaturalHazardId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "OccupancyId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ProtectionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "RiskEngineerOpinionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyDate",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyFlowStatusId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyNo",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyStatusId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "TranNo",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LocaltionName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "InsuredName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "SurveyedPremises",
                table: "Survey",
                newName: "ProtectionDetailId");

            migrationBuilder.RenameColumn(
                name: "Ownership",
                table: "Survey",
                newName: "PosNegApsectId");

            migrationBuilder.RenameColumn(
                name: "InsuredName",
                table: "Survey",
                newName: "LossEstimateId");

            migrationBuilder.AddColumn<string>(
                name: "WordingContent",
                table: "Wording",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SurveyedBy",
                table: "Survey",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Occupancy",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationAddress",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LatitudeLongitude",
                table: "Survey",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccompaniedBy",
                table: "Survey",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Survey",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConferredWith",
                table: "Survey",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfVisit",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtFireExpExposuresId",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossEstimate",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Management",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BranchId",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "Location",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "Client",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientCode",
                table: "Client",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientAddress",
                table: "Client",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientAddress = table.Column<int>(type: "int", nullable: false),
                    ClientCode = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chart",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XMLCode = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Construction",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstructionContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ConstructedIn = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LayoutContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    LayoutContructionArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LayoutSiteArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Construction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionBuilding",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NameOfBuilding = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ColumnBeam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ConstructionBuildingNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NumberOfFloors = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Roof = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Wall = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionBuilding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtFireExpExposures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EastArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EastContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FactoryName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    NorthArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NorthContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SouthArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SouthContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    WestArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WestContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtFireExpExposures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LossEstimation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PMLPercent = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PML = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValueBrkdwnInterest = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValueBrkdwnSum = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LossEstimation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Management",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HKContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    IrregWorkCtrlContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    MaintProgramContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    PlantEmgPlanDrillsContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SafetyMgmtContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SmokePolicyContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupancy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChartId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SpecialHazardContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    AttachmentId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InstalledPosition = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    TechnicalSpec = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    UtilityTypeId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IndGasSupTypeId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupancy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherExposures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NaturalHazardTypeContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    NaturalHazardTypeId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherExposures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherExposuresImg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    AttachmentId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Size = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Scale = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherExposuresImg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PosNegApsect",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosNegTypeId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    PosNegContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosNegApsect", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Protection",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoSprinklerSystemContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FireAlarmSystemsContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FireExtingSystemContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FireHydrantsHoseReelsContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FireWaterSupplyContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    GasDetectionSystemContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    InHouseFireBrigadeContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    PublicFireBrigadeContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProtectionDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    InstalledArea = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    OccupiedPercent = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Capacity = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyEvaluation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyCategoryTypeId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SurveyStatusId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyEvaluation", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "Chart");

            migrationBuilder.DropTable(
                name: "Construction");

            migrationBuilder.DropTable(
                name: "ConstructionBuilding");

            migrationBuilder.DropTable(
                name: "ExtFireExpExposures");

            migrationBuilder.DropTable(
                name: "LossEstimation");

            migrationBuilder.DropTable(
                name: "Management");

            migrationBuilder.DropTable(
                name: "Occupancy");

            migrationBuilder.DropTable(
                name: "OtherExposures");

            migrationBuilder.DropTable(
                name: "OtherExposuresImg");

            migrationBuilder.DropTable(
                name: "PosNegApsect");

            migrationBuilder.DropTable(
                name: "Protection");

            migrationBuilder.DropTable(
                name: "ProtectionDetail");

            migrationBuilder.DropTable(
                name: "SurveyEvaluation");

            migrationBuilder.DropColumn(
                name: "WordingContent",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "AccompaniedBy",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ConferredWith",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "DateOfVisit",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ExtFireExpExposuresId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LossEstimate",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Management",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "Location");

            migrationBuilder.RenameColumn(
                name: "ProtectionDetailId",
                table: "Survey",
                newName: "SurveyedPremises");

            migrationBuilder.RenameColumn(
                name: "PosNegApsectId",
                table: "Survey",
                newName: "Ownership");

            migrationBuilder.RenameColumn(
                name: "LossEstimateId",
                table: "Survey",
                newName: "InsuredName");

            migrationBuilder.AddColumn<int>(
                name: "WordingTypeId",
                table: "Wording",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SurveyedBy",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Occupancy",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationAddress",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LatitudeLongitude",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "Survey",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClientTypeId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ConstructionBuildingId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ConstructionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ExposureId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "HoREOpinionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LineOfBusinessId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LossHistoryId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ManagementId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NaturalHazardId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Survey",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OccupancyId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProtectionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RiskEngineerOpinionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SurveyDate",
                table: "Survey",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyFlowStatusId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SurveyNo",
                table: "Survey",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyStatusId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TranNo",
                table: "Survey",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BranchId",
                table: "Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocaltionName",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProvinceId",
                table: "Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientCode",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientAddress",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuredName",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }
    }
}
