using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class remove_survey_models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appendix");

            migrationBuilder.DropTable(
                name: "Chart");

            migrationBuilder.DropTable(
                name: "Construction");

            migrationBuilder.DropTable(
                name: "ConstructionBuilding");

            migrationBuilder.DropTable(
                name: "ConstructionInfo");

            migrationBuilder.DropTable(
                name: "ExtFireExpExposures");

            migrationBuilder.DropTable(
                name: "LossControl");

            migrationBuilder.DropTable(
                name: "LossExpValueBrkdwn");

            migrationBuilder.DropTable(
                name: "LossExpValueBrkdwnDetail");

            migrationBuilder.DropTable(
                name: "LossHistory");

            migrationBuilder.DropTable(
                name: "LossHistoryDetail");

            migrationBuilder.DropTable(
                name: "Management");

            migrationBuilder.DropTable(
                name: "Occupancy");

            migrationBuilder.DropTable(
                name: "OccupancyDetail");

            migrationBuilder.DropTable(
                name: "OtherExposures");

            migrationBuilder.DropTable(
                name: "OtherExposuresImg");

            migrationBuilder.DropTable(
                name: "Outline");

            migrationBuilder.DropTable(
                name: "OutlineDynamic");

            migrationBuilder.DropTable(
                name: "ParticipantList");

            migrationBuilder.DropTable(
                name: "Protection");

            migrationBuilder.DropTable(
                name: "ProtectionDetail");

            migrationBuilder.DropTable(
                name: "SitePictures");

            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropTable(
                name: "SurveyActionConfig");

            migrationBuilder.DropTable(
                name: "SurveyEvaluation");

            migrationBuilder.DropTable(
                name: "SurveyMemoWorkflow");

            migrationBuilder.DropTable(
                name: "SurveyOutlineOptions");

            migrationBuilder.DropTable(
                name: "SurveyWorkflow");

            migrationBuilder.DropTable(
                name: "SurveyWorkflowHistory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appendix",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlantLayoutContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appendix", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chart",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentId = table.Column<long>(type: "bigint", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    XMLCode = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
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
                    AdditionalOutline = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BuildingConditions = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ConstructionBuildingPivot = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ConstructionContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FireSpreadRisk = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    LayoutContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true)
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
                    ColumnBeam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ConstructionBuildingNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Height = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameOfBuilding = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    NumberOfFloors = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NumberOfStories = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Occupancy = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Pillars = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Roof = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    Wall = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    YearBuilt = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionBuilding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtFireExpExposures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalOutline = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EastArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EastContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FactoryName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    FooterContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NaturalHazardPicContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    NorthArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NorthContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    Security = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SouthArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SouthContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SurroundingAreas = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    WestArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WestContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtFireExpExposures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LossControl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovalBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientCode = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    DateOfVisit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GrantSurvey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    LatitudeLongitude = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    LocationAddress = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    LossControlNo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NeedPDFConvert = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    OwnerReport = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ownership = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    PowerPointRendered = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    RecallReason = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    SurveyedBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SurveyedByAccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SurveyedPremises = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    WordRendered = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LossControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LossExpValueBrkdwn",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PMLContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    ValueBrkdwnContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LossExpValueBrkdwn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LossExpValueBrkdwnDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PML = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    PMLPercent = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    ValueBrkdwnInterest = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValueBrkdwnSum = table.Column<decimal>(type: "decimal(28,9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LossExpValueBrkdwnDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LossHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    LossHistoryContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LossHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LossHistoryDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimNo = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    LossDate = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossDescriptions = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    TotalLoss = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LossHistoryDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Management",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalOutline = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ChemicalStorageSafety = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    HKContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    HotWorks = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    IrregWorkCtrlContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    MaintProgramContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OperationDetails = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    PlantEmgPlanDrillsContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SafetyMgmtContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SmokePolicyContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
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
                    AdditionalOutline = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductionProcessContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SpecialHazardContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    StorageConditions = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SubAttributes = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Utilities = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupancy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OccupancyDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IndGasSupCategoryTypeId = table.Column<long>(type: "bigint", nullable: true),
                    IndGasSupTypeId = table.Column<long>(type: "bigint", nullable: true),
                    InstalledPosition = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    TechnicalSpec = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    UtilityTypeId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupancyDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherExposures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalOutline = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NaturalHazardPicContent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    Security = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SurroundingAreas = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
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
                    AttachmentId = table.Column<long>(type: "bigint", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    Scale = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Size = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherExposuresImg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outline",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FontColor = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FontSize = table.Column<int>(type: "int", nullable: false),
                    FontStyle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsBold = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsItalic = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsUnderline = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ListStyleId = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    PlaceHolder = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyTypeId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutlineDynamic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FontColor = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FontSize = table.Column<int>(type: "int", nullable: false),
                    FontStyle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsBold = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsItalic = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsUnderline = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ListStyleId = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    PlaceHolder = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyTypeId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutlineDynamic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantList",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsClient = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonDepartment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SideId = table.Column<long>(type: "bigint", nullable: true),
                    SideName = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SideOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Protection",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalOutline = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FireProtection = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    LightingProtection = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    MaintenanceProgram = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublicFireBrigade = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SecurityControl = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
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
                    Amount = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Availability = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Capacity = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CoverAreasRemarks = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FirefightingEquipmentId = table.Column<long>(type: "bigint", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    InstalledArea = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OccupiedPercent = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SitePictures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentId = table.Column<long>(type: "bigint", nullable: true),
                    AttachmentNote = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SitePictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIntroduction = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpansionPlan = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OperationsDetail = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RecentModifications = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyActionConfig",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionText = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ActionType = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsCreatedBy = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsOwnerReport = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MustDifferentOwner = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    RequireInstanceWorkflow = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    RuleNo = table.Column<int>(type: "int", nullable: true),
                    StatusKey = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyActionConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyEvaluation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyCategoryTypeId = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    SurveyStatusId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyEvaluation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyMemoWorkflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutlineId = table.Column<long>(type: "bigint", nullable: true),
                    OutlineName = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    OutlineOrder = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    OutlinePage = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyMemoWorkflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyOutlineOptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MainEnable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OptionValue = table.Column<int>(type: "int", nullable: true),
                    OutlineId = table.Column<long>(type: "bigint", nullable: true),
                    Placeholder = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyOutlineOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyWorkflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyWorkflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyWorkflowHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovalBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FromAccount = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FromWorkflowStatus = table.Column<long>(type: "bigint", nullable: true),
                    GrantSurvey = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecallReason = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    SubmitBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    SurveyNo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SurveyedBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ToAccount = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ToWorkflowStatus = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyWorkflowHistory", x => x.Id);
                });
        }
    }
}
