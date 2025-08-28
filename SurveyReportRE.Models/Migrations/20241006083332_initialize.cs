using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Models.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //            migrationBuilder.DropForeignKey(
            //                name: "FK_AspNetUsers_Employee_EmployeeId",
            //                table: "AspNetUsers");

            //            migrationBuilder.DropForeignKey(
            //                name: "FK_BusinessUnit_Employee_HeadEmpId",
            //                table: "BusinessUnit");

            //            migrationBuilder.DropTable(
            //                name: "Attachment");

            //            migrationBuilder.DropTable(
            //                name: "AuditEntryProperty");

            //            migrationBuilder.DropTable(
            //                name: "BankAccount");

            //            migrationBuilder.DropTable(
            //                name: "BusinessPartner");

            //            migrationBuilder.DropTable(
            //                name: "BzTripPlace");

            //            migrationBuilder.DropTable(
            //                name: "CheckIn");

            //            migrationBuilder.DropTable(
            //                name: "Contact");

            //            migrationBuilder.DropTable(
            //                name: "CustomerType");

            //            migrationBuilder.DropTable(
            //                name: "DeliveryManagementLine");

            //            migrationBuilder.DropTable(
            //                name: "EmpActivityLog");

            //            migrationBuilder.DropTable(
            //                name: "EmpAllowance");

            //            migrationBuilder.DropTable(
            //                name: "EmpDependent");

            //            migrationBuilder.DropTable(
            //                name: "EmpEducation");

            //            migrationBuilder.DropTable(
            //                name: "EmpFamily");

            //            migrationBuilder.DropTable(
            //                name: "EmpHobby");

            //            migrationBuilder.DropTable(
            //                name: "EmployeeCJKPIHist");

            //            migrationBuilder.DropTable(
            //                name: "EmployeeCTO");

            //            migrationBuilder.DropTable(
            //                name: "EmployeeGroupMapping");

            //            migrationBuilder.DropTable(
            //                name: "EmpSubordinate");

            //            migrationBuilder.DropTable(
            //                name: "EmpTaxInsurance");

            //            migrationBuilder.DropTable(
            //                name: "EmpTrainingActivity");

            //            migrationBuilder.DropTable(
            //                name: "EmpWorkContract");

            //            migrationBuilder.DropTable(
            //                name: "EmpWorkExp");

            //            migrationBuilder.DropTable(
            //                name: "EmpWorkHist");

            //            migrationBuilder.DropTable(
            //                name: "EmpWorkingDay");

            //            migrationBuilder.DropTable(
            //                name: "EnumManufacturingGroupByTypeConfig");

            //            migrationBuilder.DropTable(
            //                name: "EnumMaterialTypeByCompositionConfig");

            //            migrationBuilder.DropTable(
            //                name: "EnumMaterialTypeByUnitConfig");

            //            migrationBuilder.DropTable(
            //                name: "EnumMOBalanceTypeLineConfig");

            //            migrationBuilder.DropTable(
            //                name: "EQDFieldValidation");

            //            migrationBuilder.DropTable(
            //                name: "EQDJoinStatement");

            //            migrationBuilder.DropTable(
            //                name: "EQDQueryTable");

            //            migrationBuilder.DropTable(
            //                name: "EQDSortOrderStatement");

            //            migrationBuilder.DropTable(
            //                name: "EQDWhereStatement");

            //            migrationBuilder.DropTable(
            //                name: "Files");

            //            migrationBuilder.DropTable(
            //                name: "Images");

            //            migrationBuilder.DropTable(
            //                name: "InwardOrderLine");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturerType");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingCoefficient");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingOrderBalanceLine");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingOrderBomLine");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingOrderMixingColorLine");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingPriceLine");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingSize");

            //            migrationBuilder.DropTable(
            //                name: "MaterialBookingWareHouseLine");

            //            migrationBuilder.DropTable(
            //                name: "MaterialDetail");

            //            migrationBuilder.DropTable(
            //                name: "MaterialIssueWareHouseLine");

            //            migrationBuilder.DropTable(
            //                name: "MaterialOnhandWareHouse");

            //            migrationBuilder.DropTable(
            //                name: "MaterialOnhandWareHouseLog");

            //            migrationBuilder.DropTable(
            //                name: "MaterialOnhandWareHouseRequestLog");

            //            migrationBuilder.DropTable(
            //                name: "MaterialOutwardWareHouseLog");

            //            migrationBuilder.DropTable(
            //                name: "MaterialReceiptWareHouseLine");

            //            migrationBuilder.DropTable(
            //                name: "MaterialReplacement");

            //            migrationBuilder.DropTable(
            //                name: "MenuItem");

            //            migrationBuilder.DropTable(
            //                name: "MonthlyAssignmentLine");

            //            migrationBuilder.DropTable(
            //                name: "MonthlyAttendance");

            //            migrationBuilder.DropTable(
            //                name: "MonthlyAttendanceCTO");

            //            migrationBuilder.DropTable(
            //                name: "NotifyDismiss");

            //            migrationBuilder.DropTable(
            //                name: "NotifyMessageQueue");

            //            migrationBuilder.DropTable(
            //                name: "NotifyRuleMapping");

            //            migrationBuilder.DropTable(
            //                name: "OnboardRequest");

            //            migrationBuilder.DropTable(
            //                name: "PricePolicy");

            //            migrationBuilder.DropTable(
            //                name: "PriceStructureLine");

            //            migrationBuilder.DropTable(
            //                name: "PriceStructureProfitByProduct");

            //            migrationBuilder.DropTable(
            //                name: "ProductCodeDevelopingHistory");

            //            migrationBuilder.DropTable(
            //                name: "ProductCodeManufacturingHistory");

            //            migrationBuilder.DropTable(
            //                name: "ProductCodeOrdersHistory");

            //            migrationBuilder.DropTable(
            //                name: "ProductExportWareHouseLine");

            //            migrationBuilder.DropTable(
            //                name: "ProductInventoryWareHouseLine");

            //            migrationBuilder.DropTable(
            //                name: "ProductionActivityDetailLine");

            //            migrationBuilder.DropTable(
            //                name: "ProductionActivityLineHistory");

            //            migrationBuilder.DropTable(
            //                name: "ProductionActivitySizeColor");

            //            migrationBuilder.DropTable(
            //                name: "ProductPlanPrintingEmbroidery");

            //            migrationBuilder.DropTable(
            //                name: "PublicCall");

            //            migrationBuilder.DropTable(
            //                name: "QuickOrderLine");

            //            migrationBuilder.DropTable(
            //                name: "ResignRequest");

            //            migrationBuilder.DropTable(
            //                name: "SaleQuotationLine");

            //            migrationBuilder.DropTable(
            //                name: "SalesOrderColorRates");

            //            migrationBuilder.DropTable(
            //                name: "SalesOrderSize");

            //            migrationBuilder.DropTable(
            //                name: "SampleCost");

            //            migrationBuilder.DropTable(
            //                name: "SampleMaterialPriceLine");

            //            migrationBuilder.DropTable(
            //                name: "SamplePriceLine");

            //            migrationBuilder.DropTable(
            //                name: "SeriLogs");

            //            migrationBuilder.DropTable(
            //                name: "SysGlobalRecordManaging");

            //            migrationBuilder.DropTable(
            //                name: "SysLanguageCaption");

            //            migrationBuilder.DropTable(
            //                name: "SysLanguageCaptionUsing");

            //            migrationBuilder.DropTable(
            //                name: "SysNumberSequence");

            //            migrationBuilder.DropTable(
            //                name: "Tasks");

            //            migrationBuilder.DropTable(
            //                name: "UserSession");

            //            migrationBuilder.DropTable(
            //                name: "WFActionRule");

            //            migrationBuilder.DropTable(
            //                name: "WFFinanceRequestSetting");

            //            migrationBuilder.DropTable(
            //                name: "WFInstanceHist");

            //            migrationBuilder.DropTable(
            //                name: "WFInstanceStatusActorAssigment");

            //            migrationBuilder.DropTable(
            //                name: "WFStatusActorPermission");

            //            migrationBuilder.DropTable(
            //                name: "WFStatusApproverDefault");

            //            migrationBuilder.DropTable(
            //                name: "WorkExtraFee");

            //            migrationBuilder.DropTable(
            //                name: "AuditEntry");

            //            migrationBuilder.DropTable(
            //                name: "DeliveryManagement");

            //            migrationBuilder.DropTable(
            //                name: "EmployeeCJKPI");

            //            migrationBuilder.DropTable(
            //                name: "Candidate");

            //            migrationBuilder.DropTable(
            //                name: "WorkingDay");

            //            migrationBuilder.DropTable(
            //                name: "EQDSelectFieldStatement");

            //            migrationBuilder.DropTable(
            //                name: "EnumSizeScaleConfig");

            //            migrationBuilder.DropTable(
            //                name: "MaterialReceiptWareHouse");

            //            migrationBuilder.DropTable(
            //                name: "MonthlyAssignment");

            //            migrationBuilder.DropTable(
            //                name: "ProductExportWareHouse");

            //            migrationBuilder.DropTable(
            //                name: "ProductInventoryWareHouse");

            //            migrationBuilder.DropTable(
            //                name: "ProductionActivityAccessoriesSupply");

            //            migrationBuilder.DropTable(
            //                name: "QuickOrder");

            //            migrationBuilder.DropTable(
            //                name: "SaleQuotation");

            //            migrationBuilder.DropTable(
            //                name: "BOM");

            //            migrationBuilder.DropTable(
            //                name: "ProductPlanLogCoefficient");

            //            migrationBuilder.DropTable(
            //                name: "SampleMaterialLine");

            //            migrationBuilder.DropTable(
            //                name: "SamplePrice");

            //            migrationBuilder.DropTable(
            //                name: "SysLanguage");

            //            migrationBuilder.DropTable(
            //                name: "WFStatusAction");

            //            migrationBuilder.DropTable(
            //                name: "WFInstance");

            //            migrationBuilder.DropTable(
            //                name: "WorkType");

            //            migrationBuilder.DropTable(
            //                name: "EQDField");

            //            migrationBuilder.DropTable(
            //                name: "EQDQuery");

            //            migrationBuilder.DropTable(
            //                name: "InwardOrder");

            //            migrationBuilder.DropTable(
            //                name: "ProductRequestWareHouseLine");

            //            migrationBuilder.DropTable(
            //                name: "ProductionActivityBalanceLine");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingDetail");

            //            migrationBuilder.DropTable(
            //                name: "ProductPlanLog");

            //            migrationBuilder.DropTable(
            //                name: "MaterialIssueWareHouse");

            //            migrationBuilder.DropTable(
            //                name: "PriceStructure");

            //            migrationBuilder.DropTable(
            //                name: "NotifyAppSubscribe");

            //            migrationBuilder.DropTable(
            //                name: "NotifyMailSubscribe");

            //            migrationBuilder.DropTable(
            //                name: "WFStatus");

            //            migrationBuilder.DropTable(
            //                name: "EQDLookupField");

            //            migrationBuilder.DropTable(
            //                name: "SysObject");

            //            migrationBuilder.DropTable(
            //                name: "ProductRequestWareHouse");

            //            migrationBuilder.DropTable(
            //                name: "ProductionActivityLine");

            //            migrationBuilder.DropTable(
            //                name: "Material");

            //            migrationBuilder.DropTable(
            //                name: "Manufacturing");

            //            migrationBuilder.DropTable(
            //                name: "ProductPlan");

            //            migrationBuilder.DropTable(
            //                name: "Location");

            //            migrationBuilder.DropTable(
            //                name: "MaterialRequestWareHouse");

            //            migrationBuilder.DropTable(
            //                name: "Supplier");

            //            migrationBuilder.DropTable(
            //                name: "NotifyRule");

            //            migrationBuilder.DropTable(
            //                name: "EmployeeGroup");

            //            migrationBuilder.DropTable(
            //                name: "WF");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingOrderLine");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingPrice");

            //            migrationBuilder.DropTable(
            //                name: "SampleOrder");

            //            migrationBuilder.DropTable(
            //                name: "Warehouse");

            //            migrationBuilder.DropTable(
            //                name: "SysEntity");

            //            migrationBuilder.DropTable(
            //                name: "SalesOrderLine");

            //            migrationBuilder.DropTable(
            //                name: "ProductionActivity");

            //            migrationBuilder.DropTable(
            //                name: "Manufacturer");

            //            migrationBuilder.DropTable(
            //                name: "EQDTable");

            //            migrationBuilder.DropTable(
            //                name: "SalesOrder");

            //            migrationBuilder.DropTable(
            //                name: "ManufacturingOrder");

            //            migrationBuilder.DropTable(
            //                name: "Customer");

            //            migrationBuilder.DropTable(
            //                name: "ProductCode");

            //            migrationBuilder.DropTable(
            //                name: "Employee");

            //            migrationBuilder.DropTable(
            //                name: "Position");

            //            migrationBuilder.DropTable(
            //                name: "BusinessUnit");

            //            migrationBuilder.DropTable(
            //                name: "SysEnumElement");

            //            migrationBuilder.DropTable(
            //                name: "SysEnum");

            //            migrationBuilder.DropIndex(
            //                name: "IX_AspNetUsers_EmployeeId",
            //                table: "AspNetUsers");
            //        }

            //        /// <inheritdoc />
            //        protected override void Down(MigrationBuilder migrationBuilder)
            //        {
            //            migrationBuilder.CreateTable(
            //                name: "AuditEntry",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
            //                    EntitySetName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EntityTypeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RecordId = table.Column<int>(type: "int", nullable: true),
            //                    State = table.Column<int>(type: "int", nullable: false),
            //                    StateName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_AuditEntry", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Contact",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CMNDIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CMNDIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CMNDNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ContactName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OfficePhone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    OwnerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    PersonalPhone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PhoneNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Posistion = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Title = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Contact", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDLookupField",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApiMethod = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomQuery = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    DisplayExpr = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DisplayFields = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    EntityQueryName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    EnumSource = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FilterOption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HiddenFields = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LookupOption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysEnumId = table.Column<int>(type: "int", nullable: true),
            //                    ValueExpr = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDLookupField", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDTable",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Alias = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Module = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDTable", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Files",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DeletedOnPhyical = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Discriminator = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
            //                    ExtrenalUrl = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
            //                    FileName = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SubDirectory = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    ThumbL = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    ThumbM = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    ThumbS = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Files", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Location",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    AdressNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Fax = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Fullname = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsPrimary = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OwnerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    PhoneNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TaxID = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Website = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Location", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MenuItem",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Action = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ActionUri = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Area = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Controller = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    Icon = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsMobile = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MenuItemId = table.Column<int>(type: "int", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Parameter = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ParentId = table.Column<int>(type: "int", nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MenuItem", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MenuItem_MenuItem_MenuItemId",
            //                        column: x => x.MenuItemId,
            //                        principalTable: "MenuItem",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MonthlyAttendanceCTO",
            //                columns: table => new
            //                {
            //                    Approved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Approver = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ApproverId = table.Column<int>(type: "int", nullable: true),
            //                    AttendanceDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Bz = table.Column<int>(type: "int", nullable: true),
            //                    Bzo = table.Column<int>(type: "int", nullable: true),
            //                    BzoTexts = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Calculated = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DepGroup = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DepOrder = table.Column<int>(type: "int", nullable: true),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DivGroup = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DivOrder = table.Column<int>(type: "int", nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpGroup = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    FullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HRComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    HRLocked = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Id = table.Column<int>(type: "int", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LeaveDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    MgrComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Month = table.Column<int>(type: "int", nullable: true),
            //                    MonthDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    OTHoliDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    OTSunDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    OTWeekDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Recorder = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StaffNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Status = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Submitted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Submitter = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SubmitterId = table.Column<int>(type: "int", nullable: true),
            //                    TSRecorderId = table.Column<int>(type: "int", nullable: true),
            //                    Team = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    UnpaidDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    WorkExtraFeeAmount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    WorkExtraFeeTexts = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Year = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "NotifyMessageQueue",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmailBody = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    EmailCc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    EmailSubject = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    EmailTo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    EmpEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Message = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Method = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RecordGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    RuleName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Status = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_NotifyMessageQueue", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "NotifyRule",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Query = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ZeroIsPassed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0")
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_NotifyRule", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "PriceStructure",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_PriceStructure", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "PublicCall",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Action = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Controller = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    ExpireTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Expired = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Param1 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Param2 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Param3 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ReactionBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ReactionMailSubject = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ReactionMailTo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ReactionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    RecordGuiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    RecordId = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_PublicCall", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SeriLogs",
            //                columns: table => new
            //                {
            //                    Id = table.Column<long>(type: "bigint", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Exception = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    Level = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LogEvent = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    Message = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    MessageTemplate = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    Properties = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    TimeStamp = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SeriLogs", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysEnum",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    AdminHandling = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EnumCaption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EnumName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysEnum", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysGlobalRecordManaging",
            //                columns: table => new
            //                {
            //                    Id = table.Column<long>(type: "bigint", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    LocatedTable = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RecordId = table.Column<int>(type: "int", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysGlobalRecordManaging", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysLanguage",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    ISOCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LangCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysLanguage", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysNumberSequence",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    AllowDel = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    BusinessPartnerId = table.Column<int>(type: "int", nullable: true),
            //                    BusinessPartnerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CreatedDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CustVendAC = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CustVendACType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DataAreaId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DateFormat = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DisplayDateSeqFormat = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Format = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IncludeDateSeq = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDefault = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsManual = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsSysNum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    Largest = table.Column<long>(type: "bigint", nullable: false),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastUsedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Manual = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ModifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Module = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Next = table.Column<long>(type: "bigint", nullable: false),
            //                    NumberSeqCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RefField = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RefTable = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Smallest = table.Column<long>(type: "bigint", nullable: false),
            //                    TableGroupAll = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Type = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysNumberSequence", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "UserSession",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    UserId = table.Column<int>(type: "int", nullable: false),
            //                    ClientDevice = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Duration = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IPAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SessionGuid = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Terminate = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    UserName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_UserSession", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_UserSession_AspNetUsers_UserId",
            //                        column: x => x.UserId,
            //                        principalTable: "AspNetUsers",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WorkExtraFee",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Amount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WorkExtraFee", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WorkType",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LeaveCount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    OffCount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    UsedInAttenance = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    UsedInDayWeek = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    WorkCount = table.Column<decimal>(type: "decimal(28,9)", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WorkType", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "AuditEntryProperty",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    AuditEntryID = table.Column<int>(type: "int", nullable: false),
            //                    NewValue = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    OldValue = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    PropertyName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RelationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_AuditEntryProperty", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_AuditEntryProperty_AuditEntry_AuditEntryID",
            //                        column: x => x.AuditEntryID,
            //                        principalTable: "AuditEntry",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDField",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDLookupFieldId = table.Column<int>(type: "int", nullable: true),
            //                    EQDTableId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DataType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DefaultValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsMandatory = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsReadOnly = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Length = table.Column<int>(type: "int", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDField", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDField_EQDLookupField_EQDLookupFieldId",
            //                        column: x => x.EQDLookupFieldId,
            //                        principalTable: "EQDLookupField",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EQDField_EQDTable_EQDTableId",
            //                        column: x => x.EQDTableId,
            //                        principalTable: "EQDTable",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysEntity",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDTableId = table.Column<int>(type: "int", nullable: true),
            //                    CombineKey = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EQDTableName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Module = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    WhereCondition = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysEntity", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SysEntity_EQDTable_EQDTableId",
            //                        column: x => x.EQDTableId,
            //                        principalTable: "EQDTable",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "NotifyAppSubscribe",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    NotifyRuleId = table.Column<int>(type: "int", nullable: false),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MessageTemplate = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    NotifyRuleName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    QueryEmployees = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    QueryMessageFields = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_NotifyAppSubscribe", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_NotifyAppSubscribe_NotifyRule_NotifyRuleId",
            //                        column: x => x.NotifyRuleId,
            //                        principalTable: "NotifyRule",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "NotifyDismiss",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    NotifyRuleId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    NotifyRuleName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RecordGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_NotifyDismiss", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_NotifyDismiss_NotifyRule_NotifyRuleId",
            //                        column: x => x.NotifyRuleId,
            //                        principalTable: "NotifyRule",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "NotifyMailSubscribe",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    NotifyRuleId = table.Column<int>(type: "int", nullable: false),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmailBodyTemplate = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    EmailCcTemplate = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    EmailSubjectTemplate = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    EmailToTemplate = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    NotifyRuleName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    QueryEmailFields = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_NotifyMailSubscribe", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_NotifyMailSubscribe_NotifyRule_NotifyRuleId",
            //                        column: x => x.NotifyRuleId,
            //                        principalTable: "NotifyRule",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "NotifyRuleMapping",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    NotifyRuleId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    NotifyRuleName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysObjectActionId = table.Column<int>(type: "int", nullable: false),
            //                    SysObjectActionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_NotifyRuleMapping", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_NotifyRuleMapping_NotifyRule_NotifyRuleId",
            //                        column: x => x.NotifyRuleId,
            //                        principalTable: "NotifyRule",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysEnumElement",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ParentId = table.Column<int>(type: "int", nullable: true),
            //                    SysEnumId = table.Column<int>(type: "int", nullable: false),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JsonCodeAttribute = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
            //                    Reference = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    Unit = table.Column<int>(type: "int", nullable: true),
            //                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysEnumElement", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SysEnumElement_SysEnumElement_ParentId",
            //                        column: x => x.ParentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SysEnumElement_SysEnum_SysEnumId",
            //                        column: x => x.SysEnumId,
            //                        principalTable: "SysEnum",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysLanguageCaption",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SysLanguageId = table.Column<int>(type: "int", nullable: false),
            //                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysLanguageCaption", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SysLanguageCaption_SysLanguage_SysLanguageId",
            //                        column: x => x.SysLanguageId,
            //                        principalTable: "SysLanguage",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "BzTripPlace",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    WorkTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Amount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Currency = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    OverSea = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    WorkCount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    WorkTypeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_BzTripPlace", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_BzTripPlace_WorkType_WorkTypeId",
            //                        column: x => x.WorkTypeId,
            //                        principalTable: "WorkType",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WorkingDay",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    WorkTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
            //                    WorkCount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    WorkTypeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkingDayNo = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WorkingDay", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WorkingDay_WorkType_WorkTypeId",
            //                        column: x => x.WorkTypeId,
            //                        principalTable: "WorkType",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDFieldValidation",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDFieldId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Max = table.Column<int>(type: "int", nullable: true),
            //                    Message = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Min = table.Column<int>(type: "int", nullable: true),
            //                    Pattern = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Type = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDFieldValidation", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDFieldValidation_EQDField_EQDFieldId",
            //                        column: x => x.EQDFieldId,
            //                        principalTable: "EQDField",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WF",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SysEntityId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WF", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WF_SysEntity_SysEntityId",
            //                        column: x => x.SysEntityId,
            //                        principalTable: "SysEntity",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "BankAccount",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BankBrandId = table.Column<int>(type: "int", nullable: true),
            //                    BankId = table.Column<int>(type: "int", nullable: true),
            //                    AccountName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    AccountNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankBranch = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankInfo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Currency = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OwnerAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    OwnerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    OwnerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    OwnerType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SwiftCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_BankAccount", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_BankAccount_SysEnumElement_BankBrandId",
            //                        column: x => x.BankBrandId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BankAccount_SysEnumElement_BankId",
            //                        column: x => x.BankId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "BusinessPartner",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    AccountCodeId = table.Column<int>(type: "int", nullable: true),
            //                    BusinessPartnerGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ChannelId = table.Column<int>(type: "int", nullable: true),
            //                    CityId = table.Column<int>(type: "int", nullable: true),
            //                    CountryId = table.Column<int>(type: "int", nullable: true),
            //                    DeliveryTermId = table.Column<int>(type: "int", nullable: true),
            //                    IncoTermId = table.Column<int>(type: "int", nullable: true),
            //                    MarketId = table.Column<int>(type: "int", nullable: true),
            //                    MarketLevelId = table.Column<int>(type: "int", nullable: true),
            //                    ParentId = table.Column<int>(type: "int", nullable: true),
            //                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
            //                    RegionId = table.Column<int>(type: "int", nullable: true),
            //                    SectorId = table.Column<int>(type: "int", nullable: true),
            //                    SegmentId = table.Column<int>(type: "int", nullable: true),
            //                    TermOfDeliveryId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    BPType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CreditLimit = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    FullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IncoId = table.Column<int>(type: "int", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MID = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    QBORealmId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    WFStatusName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Website = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_BusinessPartner", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_BusinessPartner_ParentId",
            //                        column: x => x.ParentId,
            //                        principalTable: "BusinessPartner",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_AccountCodeId",
            //                        column: x => x.AccountCodeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_BusinessPartnerGroupId",
            //                        column: x => x.BusinessPartnerGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_ChannelId",
            //                        column: x => x.ChannelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_CityId",
            //                        column: x => x.CityId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_CountryId",
            //                        column: x => x.CountryId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_DeliveryTermId",
            //                        column: x => x.DeliveryTermId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_IncoTermId",
            //                        column: x => x.IncoTermId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_MarketId",
            //                        column: x => x.MarketId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_MarketLevelId",
            //                        column: x => x.MarketLevelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_PaymentTermId",
            //                        column: x => x.PaymentTermId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_RegionId",
            //                        column: x => x.RegionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_SectorId",
            //                        column: x => x.SectorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_SegmentId",
            //                        column: x => x.SegmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessPartner_SysEnumElement_TermOfDeliveryId",
            //                        column: x => x.TermOfDeliveryId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Customer",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerCompanyId = table.Column<int>(type: "int", nullable: true),
            //                    CustomerGroupId = table.Column<int>(type: "int", nullable: true),
            //                    CustomerTypeId = table.Column<int>(type: "int", nullable: true),
            //                    DistrictId = table.Column<int>(type: "int", nullable: true),
            //                    PaymentMenthodId = table.Column<int>(type: "int", nullable: true),
            //                    ProvinceId = table.Column<int>(type: "int", nullable: true),
            //                    WardId = table.Column<int>(type: "int", nullable: true),
            //                    AccountsPayable = table.Column<double>(type: "float", nullable: true),
            //                    AccountsReceivable = table.Column<double>(type: "float", nullable: true),
            //                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankAccount = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ContactPersonAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ContactPersonName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerFullname = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DebtTerm = table.Column<double>(type: "float", nullable: true),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Fax = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Gender = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IDCardNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaximumDebt = table.Column<double>(type: "float", nullable: true),
            //                    MisaCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MobilePhone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OpenAtBank = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PhoneNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PriceProgram = table.Column<double>(type: "float", nullable: true),
            //                    Salutation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TaxCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Website = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkPhone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Customer", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Customer_Customer_CustomerCompanyId",
            //                        column: x => x.CustomerCompanyId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Customer_SysEnumElement_CustomerGroupId",
            //                        column: x => x.CustomerGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Customer_SysEnumElement_CustomerTypeId",
            //                        column: x => x.CustomerTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Customer_SysEnumElement_DistrictId",
            //                        column: x => x.DistrictId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Customer_SysEnumElement_PaymentMenthodId",
            //                        column: x => x.PaymentMenthodId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Customer_SysEnumElement_ProvinceId",
            //                        column: x => x.ProvinceId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Customer_SysEnumElement_WardId",
            //                        column: x => x.WardId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "CustomerType",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CusTypeId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OwnerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_CustomerType", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_CustomerType_SysEnumElement_CusTypeId",
            //                        column: x => x.CusTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmployeeGroup",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpGroupTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmployeeGroup", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeGroup_SysEnumElement_EmpGroupTypeId",
            //                        column: x => x.EmpGroupTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EnumManufacturingGroupByTypeConfig",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturingTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SysEnumElementId = table.Column<int>(type: "int", nullable: true),
            //                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EnumManufacturingGroupByTypeConfig", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EnumManufacturingGroupByTypeConfig_SysEnumElement_ManufacturingTypeId",
            //                        column: x => x.ManufacturingTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EnumManufacturingGroupByTypeConfig_SysEnumElement_SysEnumElementId",
            //                        column: x => x.SysEnumElementId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EnumMaterialTypeByCompositionConfig",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CompositionId = table.Column<int>(type: "int", nullable: true),
            //                    SysEnumElementId = table.Column<int>(type: "int", nullable: true),
            //                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EnumMaterialTypeByCompositionConfig", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EnumMaterialTypeByCompositionConfig_SysEnumElement_CompositionId",
            //                        column: x => x.CompositionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EnumMaterialTypeByCompositionConfig_SysEnumElement_SysEnumElementId",
            //                        column: x => x.SysEnumElementId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EnumMaterialTypeByUnitConfig",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SysEnumElementId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EnumMaterialTypeByUnitConfig", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EnumMaterialTypeByUnitConfig_SysEnumElement_SysEnumElementId",
            //                        column: x => x.SysEnumElementId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EnumMaterialTypeByUnitConfig_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EnumMOBalanceTypeLineConfig",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    MaterialTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EnumMOBalanceTypeLineConfig", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EnumMOBalanceTypeLineConfig_SysEnumElement_MaterialTypeId",
            //                        column: x => x.MaterialTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EnumSizeScaleConfig",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SysEnumElementId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    GroupSizeId = table.Column<int>(type: "int", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InseamId = table.Column<int>(type: "int", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SizeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EnumSizeScaleConfig", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EnumSizeScaleConfig_SysEnumElement_SysEnumElementId",
            //                        column: x => x.SysEnumElementId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Images",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CategoryId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Avatar = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Extension = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FileName = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    RecordGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    URL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Images", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Images_SysEnumElement_CategoryId",
            //                        column: x => x.CategoryId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Manufacturer",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturerCompanyId = table.Column<int>(type: "int", nullable: true),
            //                    PartnerTypeId = table.Column<int>(type: "int", nullable: true),
            //                    PaymentMenthodId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturerFullname = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MisaCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Manufacturer_Manufacturer_ManufacturerCompanyId",
            //                        column: x => x.ManufacturerCompanyId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Manufacturer_SysEnumElement_PartnerTypeId",
            //                        column: x => x.PartnerTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Manufacturer_SysEnumElement_PaymentMenthodId",
            //                        column: x => x.PaymentMenthodId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturerType",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    PartnerTypeId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OwnerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturerType", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturerType_SysEnumElement_PartnerTypeId",
            //                        column: x => x.PartnerTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Manufacturing",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Manufacturing", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Manufacturing_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Material",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    Specification = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Material", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Material_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Material_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Material_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Material_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Material_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Material_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Material_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "PriceStructureLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CostElementId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    Cost = table.Column<double>(type: "float", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OptionId = table.Column<int>(type: "int", nullable: false),
            //                    PriceStructureId = table.Column<int>(type: "int", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_PriceStructureLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_PriceStructureLine_PriceStructure_PriceStructureId",
            //                        column: x => x.PriceStructureId,
            //                        principalTable: "PriceStructure",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_PriceStructureLine_SysEnumElement_CostElementId",
            //                        column: x => x.CostElementId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_PriceStructureLine_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "PriceStructureProfitByProduct",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    Cost = table.Column<double>(type: "float", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OptionId = table.Column<int>(type: "int", nullable: false),
            //                    PriceStructureId = table.Column<int>(type: "int", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_PriceStructureProfitByProduct", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_PriceStructureProfitByProduct_PriceStructure_PriceStructureId",
            //                        column: x => x.PriceStructureId,
            //                        principalTable: "PriceStructure",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_PriceStructureProfitByProduct_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SaleQuotation",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApprovedStatusId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SaleQuotation", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SaleQuotation_SysEnumElement_ApprovedStatusId",
            //                        column: x => x.ApprovedStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SaleQuotation_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Supplier",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    PaymentMenthodId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierGroupId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MisaCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SupplierFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Supplier", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Supplier_SysEnumElement_PaymentMenthodId",
            //                        column: x => x.PaymentMenthodId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Supplier_SysEnumElement_SupplierGroupId",
            //                        column: x => x.SupplierGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Supplier_SysEnumElement_SupplierTypeId",
            //                        column: x => x.SupplierTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysObject",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CloneOptionId = table.Column<int>(type: "int", nullable: true),
            //                    EntityId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomButton = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    EnableAttachment = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    EnableTracking = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    EnableWorkflow = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    EntityName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    GOptEditing = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    GOptSummary = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    ImportType = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysObject", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SysObject_SysEntity_EntityId",
            //                        column: x => x.EntityId,
            //                        principalTable: "SysEntity",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SysObject_SysEnumElement_CloneOptionId",
            //                        column: x => x.CloneOptionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "PricePolicy",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    PercentPrice = table.Column<decimal>(type: "decimal(28,9)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_PricePolicy", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_PricePolicy_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SalesOrder",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HandoverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    PaymentAmount = table.Column<double>(type: "float", nullable: false),
            //                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalQuantity = table.Column<int>(type: "int", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SalesOrder", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrder_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrder_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Warehouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MisaCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WarehouseFullname = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Warehouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Warehouse_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Warehouse_SysEnumElement_WarehouseTypeId",
            //                        column: x => x.WarehouseTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFStatus",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmployeeGroupId = table.Column<int>(type: "int", nullable: true),
            //                    WFId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Order = table.Column<int>(type: "int", nullable: true),
            //                    StatusName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StatusType = table.Column<int>(type: "int", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFStatus", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFStatus_EmployeeGroup_EmployeeGroupId",
            //                        column: x => x.EmployeeGroupId,
            //                        principalTable: "EmployeeGroup",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFStatus_WF_WFId",
            //                        column: x => x.WFId,
            //                        principalTable: "WF",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingCoefficient",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturingId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FixLocation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    WorkCoefficient = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingCoefficient", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingCoefficient_Manufacturing_ManufacturingId",
            //                        column: x => x.ManufacturingId,
            //                        principalTable: "Manufacturing",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingCoefficient_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingDetail",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OwnerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    ParentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    Price = table.Column<int>(type: "int", nullable: false),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingDetail", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingDetail_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingDetail_Manufacturing_ManufacturingId",
            //                        column: x => x.ManufacturingId,
            //                        principalTable: "Manufacturing",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingDetail_SysEnumElement_ManufacturerTypeId",
            //                        column: x => x.ManufacturerTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingDetail_SysEnumElement_ManufacturingGroupId",
            //                        column: x => x.ManufacturingGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialReplacement",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    ReplacementId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialReplacement", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_Material_ReplacementId",
            //                        column: x => x.ReplacementId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReplacement_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialDetail",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OwnerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    PriorityOrder = table.Column<int>(type: "int", nullable: true),
            //                    ProvideDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ReferenceCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialDetail", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialDetail_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialDetail_Supplier_SupplierId",
            //                        column: x => x.SupplierId,
            //                        principalTable: "Supplier",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDQuery",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SysObjectId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsManualEditing = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MasterTable = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    QueryString = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDQuery", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDQuery_SysObject_SysObjectId",
            //                        column: x => x.SysObjectId,
            //                        principalTable: "SysObject",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SysLanguageCaptionUsing",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SysObjectId = table.Column<int>(type: "int", nullable: false),
            //                    AltCaptionCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CaptionCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FieldName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SysLanguageCaptionUsing", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SysLanguageCaptionUsing_SysObject_SysObjectId",
            //                        column: x => x.SysObjectId,
            //                        principalTable: "SysObject",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SalesOrderLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FabricId = table.Column<int>(type: "int", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HandoverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    InvoiceAmount = table.Column<double>(type: "float", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    ProductCodeDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    ProductCodeGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeSize = table.Column<int>(type: "int", nullable: false),
            //                    ProductStatusId = table.Column<int>(type: "int", nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: false),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SalesOrderLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrderLine_SalesOrder_SalesOrderId",
            //                        column: x => x.SalesOrderId,
            //                        principalTable: "SalesOrder",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialOnhandWareHouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    LocationId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SWLId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    AvailableQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InwardAmount = table.Column<double>(type: "float", nullable: true),
            //                    InwardQuantity = table.Column<double>(type: "float", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OnhandQuantity = table.Column<double>(type: "float", nullable: true),
            //                    OutwardAmount = table.Column<double>(type: "float", nullable: true),
            //                    OutwardQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    TotalQuantity = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialOnhandWareHouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_Location_LocationId",
            //                        column: x => x.LocationId,
            //                        principalTable: "Location",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_SWLId",
            //                        column: x => x.SWLId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouse_Warehouse_WarehouseId",
            //                        column: x => x.WarehouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFInstance",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CurrentStatusId = table.Column<int>(type: "int", nullable: false),
            //                    WFId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    RecordGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFInstance", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstance_WFStatus_CurrentStatusId",
            //                        column: x => x.CurrentStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstance_WF_WFId",
            //                        column: x => x.WFId,
            //                        principalTable: "WF",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFStatusAction",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    NotifyAppSubscribeId = table.Column<int>(type: "int", nullable: true),
            //                    NotifyMailSubscribeId = table.Column<int>(type: "int", nullable: true),
            //                    ToStatusId = table.Column<int>(type: "int", nullable: false),
            //                    WFStatusId = table.Column<int>(type: "int", nullable: false),
            //                    ActionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ConfirmMessage = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomActionAPI = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsApproverPermission = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsNeedConfirm = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsSubmitterPermission = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsSupporterPermission = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsTeamPermission = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    NotifyEmailRuleId = table.Column<int>(type: "int", nullable: true),
            //                    NotifyMessageRuleId = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFStatusAction", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusAction_NotifyAppSubscribe_NotifyAppSubscribeId",
            //                        column: x => x.NotifyAppSubscribeId,
            //                        principalTable: "NotifyAppSubscribe",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusAction_NotifyMailSubscribe_NotifyMailSubscribeId",
            //                        column: x => x.NotifyMailSubscribeId,
            //                        principalTable: "NotifyMailSubscribe",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusAction_WFStatus_ToStatusId",
            //                        column: x => x.ToStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusAction_WFStatus_WFStatusId",
            //                        column: x => x.WFStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFStatusActorPermission",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    WFStatusId = table.Column<int>(type: "int", nullable: false),
            //                    ApproverPermission = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SubmitterPermission = table.Column<int>(type: "int", nullable: false),
            //                    SupporterPermission = table.Column<int>(type: "int", nullable: false),
            //                    TeamPermission = table.Column<int>(type: "int", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFStatusActorPermission", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusActorPermission_WFStatus_WFStatusId",
            //                        column: x => x.WFStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDJoinStatement",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDQueryId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    ForeignFieldName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ForeignTableAlias = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ForeignTableName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    PrimaryFieldName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PrimaryTableAlias = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PrimaryTableName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDJoinStatement", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDJoinStatement_EQDQuery_EQDQueryId",
            //                        column: x => x.EQDQueryId,
            //                        principalTable: "EQDQuery",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDQueryTable",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDQueryId = table.Column<int>(type: "int", nullable: false),
            //                    EQDTableId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDQueryTable", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDQueryTable_EQDQuery_EQDQueryId",
            //                        column: x => x.EQDQueryId,
            //                        principalTable: "EQDQuery",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EQDQueryTable_EQDTable_EQDTableId",
            //                        column: x => x.EQDTableId,
            //                        principalTable: "EQDTable",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDSelectFieldStatement",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDFieldId = table.Column<int>(type: "int", nullable: false),
            //                    EQDQueryId = table.Column<int>(type: "int", nullable: false),
            //                    CalculatedDisplayField = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DefaultValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FieldIndex = table.Column<int>(type: "int", nullable: true),
            //                    FormFieldIndex = table.Column<int>(type: "int", nullable: true),
            //                    GroupFieldCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    GroupFieldTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    GroupIndex = table.Column<int>(type: "int", nullable: true),
            //                    GroupName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    Height = table.Column<int>(type: "int", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsReadOnly = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SortIndex = table.Column<int>(type: "int", nullable: true),
            //                    SortOrder = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TableAlias = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TableName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Width = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDSelectFieldStatement", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDSelectFieldStatement_EQDField_EQDFieldId",
            //                        column: x => x.EQDFieldId,
            //                        principalTable: "EQDField",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EQDSelectFieldStatement_EQDQuery_EQDQueryId",
            //                        column: x => x.EQDQueryId,
            //                        principalTable: "EQDQuery",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SalesOrderColorRates",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: false),
            //                    QuantityTypeId = table.Column<int>(type: "int", nullable: false),
            //                    Ratio = table.Column<double>(type: "float", nullable: false),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SalesOrderColorRates", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrderColorRates_SalesOrderLine_SalesOrderLineId",
            //                        column: x => x.SalesOrderLineId,
            //                        principalTable: "SalesOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrderColorRates_SalesOrder_SalesOrderId",
            //                        column: x => x.SalesOrderId,
            //                        principalTable: "SalesOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrderColorRates_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SalesOrderSize",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ColorSizePercentRate = table.Column<double>(type: "float", nullable: false),
            //                    ColorSizeQuantity = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    QuantityTypeId = table.Column<int>(type: "int", nullable: false),
            //                    SOColorRatesId = table.Column<int>(type: "int", nullable: true),
            //                    Size = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SalesOrderSize", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrderSize_SalesOrderLine_SalesOrderLineId",
            //                        column: x => x.SalesOrderLineId,
            //                        principalTable: "SalesOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SalesOrderSize_SalesOrder_SalesOrderId",
            //                        column: x => x.SalesOrderId,
            //                        principalTable: "SalesOrder",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFActionRule",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    WFStatusActionId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFActionRule", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFActionRule_WFStatusAction_WFStatusActionId",
            //                        column: x => x.WFStatusActionId,
            //                        principalTable: "WFStatusAction",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDSortOrderStatement",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDQueryId = table.Column<int>(type: "int", nullable: false),
            //                    EQDSelectFieldStatementId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDescending = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDSortOrderStatement", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDSortOrderStatement_EQDQuery_EQDQueryId",
            //                        column: x => x.EQDQueryId,
            //                        principalTable: "EQDQuery",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EQDSortOrderStatement_EQDSelectFieldStatement_EQDSelectFieldStatementId",
            //                        column: x => x.EQDSelectFieldStatementId,
            //                        principalTable: "EQDSelectFieldStatement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EQDWhereStatement",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EQDQueryId = table.Column<int>(type: "int", nullable: false),
            //                    EQDSelectFieldStatementId = table.Column<int>(type: "int", nullable: true),
            //                    ParentEQDWhereStatementId = table.Column<int>(type: "int", nullable: true),
            //                    AndOrText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CompareValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    OperationText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EQDWhereStatement", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EQDWhereStatement_EQDQuery_EQDQueryId",
            //                        column: x => x.EQDQueryId,
            //                        principalTable: "EQDQuery",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EQDWhereStatement_EQDSelectFieldStatement_EQDSelectFieldStatementId",
            //                        column: x => x.EQDSelectFieldStatementId,
            //                        principalTable: "EQDSelectFieldStatement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EQDWhereStatement_EQDWhereStatement_ParentEQDWhereStatementId",
            //                        column: x => x.ParentEQDWhereStatementId,
            //                        principalTable: "EQDWhereStatement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Attachment",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CategoryId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmpMail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Extension = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InUse = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    InternalURL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RecordGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    RefId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Title = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    URL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Attachment", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Attachment_SysEnumElement_CategoryId",
            //                        column: x => x.CategoryId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "BOM",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BOMMaterialReplacementId = table.Column<int>(type: "int", nullable: true),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialReplacementId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SWLId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    ActualNorm = table.Column<double>(type: "float", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Comment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    CostComposition = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    ExpectedNorm = table.Column<double>(type: "float", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InUsedForManufacturing = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Location = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LocationUse = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    NumberIncrease = table.Column<int>(type: "int", nullable: false),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    isReplace = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_BOM", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_BOM_Material_BOMMaterialReplacementId",
            //                        column: x => x.BOMMaterialReplacementId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_Material_MaterialReplacementId",
            //                        column: x => x.MaterialReplacementId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_SWLId",
            //                        column: x => x.SWLId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BOM_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "BusinessUnit",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BULevelId = table.Column<int>(type: "int", nullable: true),
            //                    CompanyId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    HeadEmpId = table.Column<int>(type: "int", nullable: true),
            //                    ReportToBUId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HeadEmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
            //                    ReportToBUName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ShowInChart = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_BusinessUnit", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_BusinessUnit_BusinessUnit_ReportToBUId",
            //                        column: x => x.ReportToBUId,
            //                        principalTable: "BusinessUnit",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessUnit_SysEnumElement_BULevelId",
            //                        column: x => x.BULevelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessUnit_SysEnumElement_CompanyId",
            //                        column: x => x.CompanyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessUnit_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_BusinessUnit_SysEnumElement_DivisionId",
            //                        column: x => x.DivisionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Position",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BUId = table.Column<int>(type: "int", nullable: true),
            //                    CompanyId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    PosLevelId = table.Column<int>(type: "int", nullable: true),
            //                    ReportToPosId = table.Column<int>(type: "int", nullable: true),
            //                    TeamId = table.Column<int>(type: "int", nullable: true),
            //                    WorkPlaceId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    AddingLeaveForHardWork = table.Column<int>(type: "int", nullable: true),
            //                    BUName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ReportToPosTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ShowInChart = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    Title = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Position", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Position_BusinessUnit_BUId",
            //                        column: x => x.BUId,
            //                        principalTable: "BusinessUnit",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Position_Position_ReportToPosId",
            //                        column: x => x.ReportToPosId,
            //                        principalTable: "Position",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Position_SysEnumElement_CompanyId",
            //                        column: x => x.CompanyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Position_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Position_SysEnumElement_DivisionId",
            //                        column: x => x.DivisionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Position_SysEnumElement_PosLevelId",
            //                        column: x => x.PosLevelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Position_SysEnumElement_TeamId",
            //                        column: x => x.TeamId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Position_SysEnumElement_WorkPlaceId",
            //                        column: x => x.WorkPlaceId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Employee",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BankId = table.Column<int>(type: "int", nullable: true),
            //                    BloodTypeId = table.Column<int>(type: "int", nullable: true),
            //                    CompanyId = table.Column<int>(type: "int", nullable: true),
            //                    DelegateeId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    GenderId = table.Column<int>(type: "int", nullable: true),
            //                    HomeCityId = table.Column<int>(type: "int", nullable: true),
            //                    HomeDistrictId = table.Column<int>(type: "int", nullable: true),
            //                    LeaveApproverId = table.Column<int>(type: "int", nullable: true),
            //                    MarritalStatusId = table.Column<int>(type: "int", nullable: true),
            //                    NationalityId = table.Column<int>(type: "int", nullable: true),
            //                    PositionId = table.Column<int>(type: "int", nullable: true),
            //                    ReportToEmpId = table.Column<int>(type: "int", nullable: true),
            //                    TeamId = table.Column<int>(type: "int", nullable: true),
            //                    TempCityId = table.Column<int>(type: "int", nullable: true),
            //                    TempDistrictId = table.Column<int>(type: "int", nullable: true),
            //                    TSApproverId = table.Column<int>(type: "int", nullable: true),
            //                    TSRecorderId = table.Column<int>(type: "int", nullable: true),
            //                    TSSubmitterId = table.Column<int>(type: "int", nullable: true),
            //                    WorkPlaceId = table.Column<int>(type: "int", nullable: true),
            //                    WorkStatusId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    AttachProfileURL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
            //                    Avartar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //                    Avatar3x4 = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
            //                    BankAccountName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankAccountNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankBranch = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BeginDateOff = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    BypassTimesheet = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CMNDIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CMNDIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CMNDNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CandidateId = table.Column<int>(type: "int", nullable: true),
            //                    CandidateName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CandidatePosition = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CarBrand = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CarColor = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CarModel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CarNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ComeBack = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    DelegateeKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EID = table.Column<int>(type: "int", nullable: true),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndDateOff = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Ext = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FingerId = table.Column<int>(type: "int", nullable: true),
            //                    FirstName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HardwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    HomeAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    HomeLatitude = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IdentityID = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IdentityIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    IdentityIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    JoinedDateLegal = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    KnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LeaveApproverKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaternityEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaternityStart = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaternitySubmitLeave = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Mobile = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    OtherIncomeTax = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Phone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PlaceOfBirth = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PlaceOfOrigin = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PosLevel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PosTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProbationEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ProbationStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ReportToEmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Seal = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //                    SeatPlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ShowInChart = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    ShowInTimeSheet = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Signature = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //                    Skype = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SoftwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SpecialNotes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StaffNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TSApproverKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TSRecorderKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TSSubmitterKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TempAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TempLatitude = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Vegetable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    YearsOld = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Employee", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Employee_Employee_DelegateeId",
            //                        column: x => x.DelegateeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_Employee_LeaveApproverId",
            //                        column: x => x.LeaveApproverId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_Employee_Employee_ReportToEmpId",
            //                        column: x => x.ReportToEmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_Employee_Employee_TSApproverId",
            //                        column: x => x.TSApproverId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_Employee_Employee_TSRecorderId",
            //                        column: x => x.TSRecorderId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_Employee_Employee_TSSubmitterId",
            //                        column: x => x.TSSubmitterId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_Employee_Position_PositionId",
            //                        column: x => x.PositionId,
            //                        principalTable: "Position",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_BankId",
            //                        column: x => x.BankId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_BloodTypeId",
            //                        column: x => x.BloodTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_CompanyId",
            //                        column: x => x.CompanyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_DivisionId",
            //                        column: x => x.DivisionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_GenderId",
            //                        column: x => x.GenderId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_HomeCityId",
            //                        column: x => x.HomeCityId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_HomeDistrictId",
            //                        column: x => x.HomeDistrictId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_MarritalStatusId",
            //                        column: x => x.MarritalStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_NationalityId",
            //                        column: x => x.NationalityId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_TeamId",
            //                        column: x => x.TeamId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_TempCityId",
            //                        column: x => x.TempCityId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_TempDistrictId",
            //                        column: x => x.TempDistrictId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_WorkPlaceId",
            //                        column: x => x.WorkPlaceId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Employee_SysEnumElement_WorkStatusId",
            //                        column: x => x.WorkStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Candidate",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EduLevelId = table.Column<int>(type: "int", nullable: true),
            //                    EduTypeId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId1 = table.Column<int>(type: "int", nullable: true),
            //                    GenderId = table.Column<int>(type: "int", nullable: true),
            //                    HomeCityId = table.Column<int>(type: "int", nullable: true),
            //                    HomeDistrictId = table.Column<int>(type: "int", nullable: true),
            //                    MarritalStatusId = table.Column<int>(type: "int", nullable: true),
            //                    NationalityId = table.Column<int>(type: "int", nullable: true),
            //                    SourceId = table.Column<int>(type: "int", nullable: true),
            //                    TempCityId = table.Column<int>(type: "int", nullable: true),
            //                    TempDistrictId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    AttachProfileURL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
            //                    Avatar3x4 = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
            //                    Blacklist = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CMNDIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CMNDIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CMNDNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ExpSummary = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FirstName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HomeAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    HomeLatitude = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IdentityID = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IdentityIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    IdentityIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LeaderFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MajorName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
            //                    Mobile = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Phone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PlaceOfBirth = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PlaceOfOrigin = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PosLevel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PosTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Ranking = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SchoolName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
            //                    Skype = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SourceName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StaffNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Team = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TempAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TempLatitude = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    YearOfGrade = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Candidate", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_Employee_EmpId1",
            //                        column: x => x.EmpId1,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_EduLevelId",
            //                        column: x => x.EduLevelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_EduTypeId",
            //                        column: x => x.EduTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_GenderId",
            //                        column: x => x.GenderId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_HomeCityId",
            //                        column: x => x.HomeCityId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_HomeDistrictId",
            //                        column: x => x.HomeDistrictId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_MarritalStatusId",
            //                        column: x => x.MarritalStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_NationalityId",
            //                        column: x => x.NationalityId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_SourceId",
            //                        column: x => x.SourceId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_TempCityId",
            //                        column: x => x.TempCityId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Candidate_SysEnumElement_TempDistrictId",
            //                        column: x => x.TempDistrictId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "CheckIn",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: true),
            //                    CheckTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CheckType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DateMonth = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    EID = table.Column<int>(type: "int", nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FingerId = table.Column<int>(type: "int", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MemoInfo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SN = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SensorId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    UserExtFmt = table.Column<int>(type: "int", nullable: true),
            //                    VerifyCode = table.Column<int>(type: "int", nullable: true),
            //                    WorkCode = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_CheckIn", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_CheckIn_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpActivityLog",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    Activity = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DateLog = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpActivityLog", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpActivityLog_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpAllowance",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    AllowanceTypeId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    SupportFeeId1 = table.Column<int>(type: "int", nullable: true),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SupportFeeId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpAllowance", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpAllowance_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpAllowance_SysEnumElement_AllowanceTypeId",
            //                        column: x => x.AllowanceTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpAllowance_SysEnumElement_SupportFeeId1",
            //                        column: x => x.SupportFeeId1,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpDependent",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    GenderId = table.Column<int>(type: "int", nullable: true),
            //                    RelationTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsFamily = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Job = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Phone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RelationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    TaxCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    YearsOld = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpDependent", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpDependent_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpDependent_SysEnumElement_GenderId",
            //                        column: x => x.GenderId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpDependent_SysEnumElement_RelationTypeId",
            //                        column: x => x.RelationTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpEducation",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EduLevelId = table.Column<int>(type: "int", nullable: true),
            //                    EduTypeId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MajorName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Primary = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Ranking = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SchoolName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    YearOfGrade = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpEducation", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpEducation_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpEducation_SysEnumElement_EduLevelId",
            //                        column: x => x.EduLevelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpEducation_SysEnumElement_EduTypeId",
            //                        column: x => x.EduTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpFamily",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    GenderId = table.Column<int>(type: "int", nullable: true),
            //                    RelationTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Available = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Education = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpLinkFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpLinkId = table.Column<int>(type: "int", nullable: true),
            //                    EmpLinkKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IdentityID = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IdentityIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    IdentityIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDependent = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsEmployee = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Job = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Phone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RelationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    YearsOld = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpFamily", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpFamily_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpFamily_SysEnumElement_GenderId",
            //                        column: x => x.GenderId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpFamily_SysEnumElement_RelationTypeId",
            //                        column: x => x.RelationTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpHobby",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    HobbyId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Mostlike = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpHobby", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpHobby_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpHobby_SysEnumElement_HobbyId",
            //                        column: x => x.HobbyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmployeeCJKPI",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: false),
            //                    AllowSync = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CJMonth = table.Column<int>(type: "int", nullable: false),
            //                    CJType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJYear = table.Column<int>(type: "int", nullable: false),
            //                    CJetKPILinkedCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJetKPIName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJetScore = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    CJetTarget = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJetUserName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ERPScore = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    EmployeeKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastSubmitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmployeeCJKPI", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeCJKPI_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmployeeGroupMapping",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmployeeGroupId = table.Column<int>(type: "int", nullable: false),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmployeeGroupName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmployeeKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    PrimaryEmp = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmployeeGroupMapping", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeGroupMapping_EmployeeGroup_EmployeeGroupId",
            //                        column: x => x.EmployeeGroupId,
            //                        principalTable: "EmployeeGroup",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeGroupMapping_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpSubordinate",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    SubId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Direct = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SubKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpSubordinate", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpSubordinate_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpSubordinate_Employee_SubId",
            //                        column: x => x.SubId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpTaxInsurance",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CardTypeId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ContinuesYears = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Number = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RegisterPlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpTaxInsurance", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpTaxInsurance_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpTaxInsurance_SysEnumElement_CardTypeId",
            //                        column: x => x.CardTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpTrainingActivity",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApproverId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    SubmiterId = table.Column<int>(type: "int", nullable: true),
            //                    ApproverKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CertTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CertValidMonths = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Completed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MgrComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    NameOfFaculty = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PaidByCompany = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Ranking = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Status = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SubmiterKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalHours = table.Column<decimal>(type: "decimal(28,9)", nullable: false),
            //                    TotalMonths = table.Column<decimal>(type: "decimal(28,9)", nullable: false),
            //                    Trainer = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TrainingFee = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    TrainingProgramme = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Type = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Venue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpTrainingActivity", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpTrainingActivity_Employee_ApproverId",
            //                        column: x => x.ApproverId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpTrainingActivity_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpTrainingActivity_Employee_SubmiterId",
            //                        column: x => x.SubmiterId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpWorkContract",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ContractTypeId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ContractCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpWorkContract", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkContract_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkContract_SysEnumElement_ContractTypeId",
            //                        column: x => x.ContractTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpWorkExp",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpWorkExp", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkExp_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpWorkHist",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CompanyId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    PositionId = table.Column<int>(type: "int", nullable: true),
            //                    ReportToEmpId = table.Column<int>(type: "int", nullable: true),
            //                    TeamId = table.Column<int>(type: "int", nullable: true),
            //                    WorkHistTypeId = table.Column<int>(type: "int", nullable: true),
            //                    WorkPlaceId = table.Column<int>(type: "int", nullable: true),
            //                    WorkStatusId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JobTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    PosLevel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PosTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PrimaryEmp = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    PrimaryPos = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ReportToEmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpWorkHist", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_Employee_ReportToEmpId",
            //                        column: x => x.ReportToEmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_Position_PositionId",
            //                        column: x => x.PositionId,
            //                        principalTable: "Position",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_SysEnumElement_CompanyId",
            //                        column: x => x.CompanyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_SysEnumElement_DivisionId",
            //                        column: x => x.DivisionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_SysEnumElement_TeamId",
            //                        column: x => x.TeamId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_SysEnumElement_WorkHistTypeId",
            //                        column: x => x.WorkHistTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_SysEnumElement_WorkPlaceId",
            //                        column: x => x.WorkPlaceId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkHist_SysEnumElement_WorkStatusId",
            //                        column: x => x.WorkStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmpWorkingDay",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    WorkingDayId = table.Column<int>(type: "int", nullable: true),
            //                    WorkTypeId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndOTTime = table.Column<TimeSpan>(type: "time", nullable: true),
            //                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    StartOTTime = table.Column<TimeSpan>(type: "time", nullable: true),
            //                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
            //                    WorkCount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    WorkTypeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkingDayName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkingDayNo = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmpWorkingDay", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkingDay_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkingDay_WorkType_WorkTypeId",
            //                        column: x => x.WorkTypeId,
            //                        principalTable: "WorkType",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmpWorkingDay_WorkingDay_WorkingDayId",
            //                        column: x => x.WorkingDayId,
            //                        principalTable: "WorkingDay",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialRequestWareHouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApproveEmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    OrderTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ReasonId = table.Column<int>(type: "int", nullable: true),
            //                    RequestStatusId = table.Column<int>(type: "int", nullable: true),
            //                    RequestTypeId = table.Column<int>(type: "int", nullable: true),
            //                    WareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    ApproveEmployeeFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmployeeFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsPriority = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingList = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    SampleOrderList = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialRequestWareHouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_Employee_ApproveEmployeeId",
            //                        column: x => x.ApproveEmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_SysEnumElement_OrderTypeId",
            //                        column: x => x.OrderTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_SysEnumElement_ReasonId",
            //                        column: x => x.ReasonId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_SysEnumElement_RequestStatusId",
            //                        column: x => x.RequestStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_SysEnumElement_RequestTypeId",
            //                        column: x => x.RequestTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialRequestWareHouse_Warehouse_WareHouseId",
            //                        column: x => x.WareHouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MonthlyAssignment",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CreatorId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MonthId = table.Column<int>(type: "int", nullable: true),
            //                    YearId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CreatorKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmployeeGroupName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MonthlyAssignment", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignment_EmployeeGroup_EmployeeGroupId",
            //                        column: x => x.EmployeeGroupId,
            //                        principalTable: "EmployeeGroup",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignment_Employee_CreatorId",
            //                        column: x => x.CreatorId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignment_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignment_SysEnumElement_MonthId",
            //                        column: x => x.MonthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignment_SysEnumElement_YearId",
            //                        column: x => x.YearId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MonthlyAttendance",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApproverId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: false),
            //                    RecorderId = table.Column<int>(type: "int", nullable: true),
            //                    SubmitterId = table.Column<int>(type: "int", nullable: true),
            //                    Approved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    ApproverKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    AttendanceDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Bz = table.Column<int>(type: "int", nullable: true),
            //                    Bzo = table.Column<int>(type: "int", nullable: true),
            //                    BzoAmount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    BzoTexts = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Calculated = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    ComeEarlies = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ComeLates = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Company = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Division = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpGroup = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    F100 = table.Column<int>(type: "int", nullable: false),
            //                    F120 = table.Column<int>(type: "int", nullable: false),
            //                    F140 = table.Column<int>(type: "int", nullable: false),
            //                    F150 = table.Column<int>(type: "int", nullable: false),
            //                    F20 = table.Column<int>(type: "int", nullable: false),
            //                    F200 = table.Column<int>(type: "int", nullable: false),
            //                    F30 = table.Column<int>(type: "int", nullable: false),
            //                    F40 = table.Column<int>(type: "int", nullable: false),
            //                    F50 = table.Column<int>(type: "int", nullable: false),
            //                    F60 = table.Column<int>(type: "int", nullable: false),
            //                    F70 = table.Column<int>(type: "int", nullable: false),
            //                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HRComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    HRLocked = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LeaveDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    MgrComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Month = table.Column<int>(type: "int", nullable: false),
            //                    MonthDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    OTHoliDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    OTSunDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    OTWeekDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    OutEarlies = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OutLates = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Position = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RecorderKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StaffNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Status = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Submitted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    SubmitterKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Team = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UnpaidDays = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    WorkExtraFeeAmount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    WorkExtraFeeTexts = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Year = table.Column<int>(type: "int", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MonthlyAttendance", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAttendance_Employee_ApproverId",
            //                        column: x => x.ApproverId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAttendance_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAttendance_Employee_RecorderId",
            //                        column: x => x.RecorderId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAttendance_Employee_SubmitterId",
            //                        column: x => x.SubmitterId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "OnboardRequest",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CompanyId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    OnboardStatusId = table.Column<int>(type: "int", nullable: true),
            //                    PositionId = table.Column<int>(type: "int", nullable: true),
            //                    ReportToId = table.Column<int>(type: "int", nullable: true),
            //                    TeamId = table.Column<int>(type: "int", nullable: true),
            //                    AdminComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    AdminConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    AdminDone = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Avatar = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Brand = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Color = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Comment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CreditMemo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    DebitMemo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ExtCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ExtNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FAComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    FAConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    FADone = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    FingerId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    GuidelinePayment = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    GuidelineProcess = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    HRComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    HRConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    HRLocked = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    HardwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ITComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ITConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ITDone = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ModelCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    NeedAccountERP = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedAdminSecurityCard = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedChair = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedEmail = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedExtensionNumber = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedFinger = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedGuidelineAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedNameCard = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedSecurityCard = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedSkype = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedStationery = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Nick = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    NumberPlate = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PersonInCharge = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    PositionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ReportToName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SeatPlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SecurityCard = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Skype = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SoftwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Status = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_OnboardRequest", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_Employee_ReportToId",
            //                        column: x => x.ReportToId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_Position_PositionId",
            //                        column: x => x.PositionId,
            //                        principalTable: "Position",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_SysEnumElement_CompanyId",
            //                        column: x => x.CompanyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_SysEnumElement_DivisionId",
            //                        column: x => x.DivisionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_SysEnumElement_OnboardStatusId",
            //                        column: x => x.OnboardStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_OnboardRequest_SysEnumElement_TeamId",
            //                        column: x => x.TeamId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductCode",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    IdeaId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ProductLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SizeScaleId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    Index = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductCode", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductCode_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCode_SysEnumElement_IdeaId",
            //                        column: x => x.IdeaId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCode_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCode_SysEnumElement_ProductLineId",
            //                        column: x => x.ProductLineId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCode_SysEnumElement_ProductTypeId",
            //                        column: x => x.ProductTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCode_SysEnumElement_SizeScaleId",
            //                        column: x => x.SizeScaleId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCode_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductExportWareHouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CurrencyId = table.Column<int>(type: "int", nullable: true),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    ExportEmpId = table.Column<int>(type: "int", nullable: true),
            //                    ExportStatusId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialWHExportTypeEnumId = table.Column<int>(type: "int", nullable: true),
            //                    OrderTypesId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ExportDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ExportEmpName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    SaleTransactionCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    isLock = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductExportWareHouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_Employee_ExportEmpId",
            //                        column: x => x.ExportEmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_SysEnumElement_CurrencyId",
            //                        column: x => x.CurrencyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_SysEnumElement_ExportStatusId",
            //                        column: x => x.ExportStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_SysEnumElement_MaterialWHExportTypeEnumId",
            //                        column: x => x.MaterialWHExportTypeEnumId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_SysEnumElement_OrderTypesId",
            //                        column: x => x.OrderTypesId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouse_Warehouse_WarehouseId",
            //                        column: x => x.WarehouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductRequestWareHouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CurrencyId = table.Column<int>(type: "int", nullable: true),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    EmpId = table.Column<int>(type: "int", nullable: true),
            //                    ImportStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ImportTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialWHRequestTypeEnumId = table.Column<int>(type: "int", nullable: true),
            //                    OrderTypesId = table.Column<int>(type: "int", nullable: true),
            //                    RequestEmpId = table.Column<int>(type: "int", nullable: true),
            //                    RequestStatusId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmpName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    RequestEmpName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    isLock = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductRequestWareHouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_Employee_EmpId",
            //                        column: x => x.EmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_Employee_RequestEmpId",
            //                        column: x => x.RequestEmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_SysEnumElement_CurrencyId",
            //                        column: x => x.CurrencyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_SysEnumElement_ImportStatusId",
            //                        column: x => x.ImportStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_SysEnumElement_ImportTypeId",
            //                        column: x => x.ImportTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_SysEnumElement_MaterialWHRequestTypeEnumId",
            //                        column: x => x.MaterialWHRequestTypeEnumId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_SysEnumElement_OrderTypesId",
            //                        column: x => x.OrderTypesId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_SysEnumElement_RequestStatusId",
            //                        column: x => x.RequestStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouse_Warehouse_WarehouseId",
            //                        column: x => x.WarehouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ResignRequest",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CompanyId = table.Column<int>(type: "int", nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    PositionId = table.Column<int>(type: "int", nullable: true),
            //                    ReportToId = table.Column<int>(type: "int", nullable: true),
            //                    ResignStatusId = table.Column<int>(type: "int", nullable: true),
            //                    TeamId = table.Column<int>(type: "int", nullable: true),
            //                    AdminComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    AdminConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    AdminDone = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Avatar = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Brand = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Color = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Comment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ExtCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ExtNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FingerId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HRComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    HRConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    HRLocked = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    HardwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ITComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ITConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ITDone = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ModelCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    NeedAccountERP = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedAdminSecurityCard = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedChair = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedEmail = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedExtensionNumber = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedFinger = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedGuidelineAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedNameCard = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedSecurityCard = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedSkype = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    NeedStationery = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Nick = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    NumberPlate = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PositionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ReportToName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SeatPlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SecurityCard = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Skype = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SoftwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Status = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ResignRequest", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_Employee_ReportToId",
            //                        column: x => x.ReportToId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_Position_PositionId",
            //                        column: x => x.PositionId,
            //                        principalTable: "Position",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_SysEnumElement_CompanyId",
            //                        column: x => x.CompanyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_SysEnumElement_DepartmentId",
            //                        column: x => x.DepartmentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_SysEnumElement_DivisionId",
            //                        column: x => x.DivisionId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_SysEnumElement_ResignStatusId",
            //                        column: x => x.ResignStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ResignRequest_SysEnumElement_TeamId",
            //                        column: x => x.TeamId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Tasks",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    AssigneeId = table.Column<int>(type: "int", nullable: true),
            //                    AssignerId = table.Column<int>(type: "int", nullable: true),
            //                    AssignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    AssigneeKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    AssignerKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Complete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CompleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    EmpComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Evaluation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    History = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MgrComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    RecordGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //                    RecordId = table.Column<int>(type: "int", nullable: false),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    TableName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Title = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Tasks", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_Tasks_Employee_AssigneeId",
            //                        column: x => x.AssigneeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_Tasks_Employee_AssignerId",
            //                        column: x => x.AssignerId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFFinanceRequestSetting",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SubmitterId = table.Column<int>(type: "int", nullable: true),
            //                    ViewerId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SubmitterKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ViewerKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFFinanceRequestSetting", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFFinanceRequestSetting_Employee_SubmitterId",
            //                        column: x => x.SubmitterId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFFinanceRequestSetting_Employee_ViewerId",
            //                        column: x => x.ViewerId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFInstanceHist",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    FromEmplId = table.Column<int>(type: "int", nullable: true),
            //                    FromStatusId = table.Column<int>(type: "int", nullable: false),
            //                    ToEmplId = table.Column<int>(type: "int", nullable: true),
            //                    ToStatusId = table.Column<int>(type: "int", nullable: false),
            //                    WFActionId = table.Column<int>(type: "int", nullable: true),
            //                    WFInstanceId = table.Column<int>(type: "int", nullable: false),
            //                    Comment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFInstanceHist", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceHist_Employee_FromEmplId",
            //                        column: x => x.FromEmplId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceHist_Employee_ToEmplId",
            //                        column: x => x.ToEmplId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceHist_WFInstance_WFInstanceId",
            //                        column: x => x.WFInstanceId,
            //                        principalTable: "WFInstance",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceHist_WFStatusAction_WFActionId",
            //                        column: x => x.WFActionId,
            //                        principalTable: "WFStatusAction",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceHist_WFStatus_FromStatusId",
            //                        column: x => x.FromStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceHist_WFStatus_ToStatusId",
            //                        column: x => x.ToStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFInstanceStatusActorAssigment",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApproverEmplId = table.Column<int>(type: "int", nullable: true),
            //                    SubmitterEmplId = table.Column<int>(type: "int", nullable: true),
            //                    SupporterEmplId = table.Column<int>(type: "int", nullable: true),
            //                    TeamId = table.Column<int>(type: "int", nullable: true),
            //                    WFInstanceId = table.Column<int>(type: "int", nullable: false),
            //                    WFStatusId = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFInstanceStatusActorAssigment", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceStatusActorAssigment_Employee_ApproverEmplId",
            //                        column: x => x.ApproverEmplId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceStatusActorAssigment_Employee_SubmitterEmplId",
            //                        column: x => x.SubmitterEmplId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceStatusActorAssigment_Employee_SupporterEmplId",
            //                        column: x => x.SupporterEmplId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceStatusActorAssigment_SysEnumElement_TeamId",
            //                        column: x => x.TeamId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceStatusActorAssigment_WFInstance_WFInstanceId",
            //                        column: x => x.WFInstanceId,
            //                        principalTable: "WFInstance",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_WFInstanceStatusActorAssigment_WFStatus_WFStatusId",
            //                        column: x => x.WFStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Restrict);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "WFStatusApproverDefault",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApproverId = table.Column<int>(type: "int", nullable: true),
            //                    SubmitterId = table.Column<int>(type: "int", nullable: true),
            //                    WFStatusId = table.Column<int>(type: "int", nullable: false),
            //                    ApproverKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SubmitterKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SudmitterGroupId = table.Column<int>(type: "int", nullable: true),
            //                    SudmitterGroupName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_WFStatusApproverDefault", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusApproverDefault_Employee_ApproverId",
            //                        column: x => x.ApproverId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusApproverDefault_Employee_SubmitterId",
            //                        column: x => x.SubmitterId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_WFStatusApproverDefault_WFStatus_WFStatusId",
            //                        column: x => x.WFStatusId,
            //                        principalTable: "WFStatus",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmployeeCTO",
            //                columns: table => new
            //                {
            //                    BankId = table.Column<int>(type: "int", nullable: true),
            //                    CandidateId = table.Column<int>(type: "int", nullable: true),
            //                    TSRecorderId = table.Column<int>(type: "int", nullable: true),
            //                    TSSubmitterId = table.Column<int>(type: "int", nullable: true),
            //                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
            //                    AttachProfileURL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
            //                    Avartar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //                    Avatar3x4 = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
            //                    BankAccountName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankAccountNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankBranch = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BankName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BloodTypeId = table.Column<int>(type: "int", nullable: true),
            //                    BypassTimesheet = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CMNDIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CMNDIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CMNDNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CandidateKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CarNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CompanyId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    DelegateeId = table.Column<int>(type: "int", nullable: true),
            //                    DelegateeKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DepartmentId = table.Column<int>(type: "int", nullable: true),
            //                    DivisionId = table.Column<int>(type: "int", nullable: true),
            //                    EID = table.Column<int>(type: "int", nullable: true),
            //                    Education = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Ext = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FingerId = table.Column<int>(type: "int", nullable: true),
            //                    FirstName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    GenderId = table.Column<int>(type: "int", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HardwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    HomeAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    HomeCityId = table.Column<int>(type: "int", nullable: true),
            //                    HomeDistrictId = table.Column<int>(type: "int", nullable: true),
            //                    HomeLatitude = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Id = table.Column<int>(type: "int", nullable: false),
            //                    IdentityID = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IdentityIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    IdentityIssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    IssuePlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    JoinedDateLegal = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    KnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LaborContract = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LastName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Leader = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LeaveApproverId = table.Column<int>(type: "int", nullable: true),
            //                    LeaveApproverKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MarriedStatusId = table.Column<int>(type: "int", nullable: true),
            //                    MarritalStatusId = table.Column<int>(type: "int", nullable: true),
            //                    MaternityEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaternityStart = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaternitySubmitLeave = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Mobile = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    NationalityId = table.Column<int>(type: "int", nullable: true),
            //                    Nick = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    PAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PCity = table.Column<int>(type: "int", nullable: true),
            //                    PDistrict = table.Column<int>(type: "int", nullable: true),
            //                    POB = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Phone = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PlaceOfBirth = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PlaceOfOrigin = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PosLevel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PosTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PositionId = table.Column<int>(type: "int", nullable: true),
            //                    PositionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PositionTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProbationEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ProbationStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ReportToEmpId = table.Column<int>(type: "int", nullable: true),
            //                    ReportToEmpKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SIBookNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SchoolName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Seal = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //                    SeatPlace = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ShowInChart = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    ShowInTimeSheet = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    Signature = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //                    Skype = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SoftwareUsing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SourceId = table.Column<int>(type: "int", nullable: true),
            //                    SourceName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StaffNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    TAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TCity = table.Column<int>(type: "int", nullable: true),
            //                    TDistrict = table.Column<int>(type: "int", nullable: true),
            //                    TSApproverId = table.Column<int>(type: "int", nullable: true),
            //                    TSApproverKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TSRecorderKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TSSubmitterKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TaxCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TeamId = table.Column<int>(type: "int", nullable: true),
            //                    TempAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TempCityId = table.Column<int>(type: "int", nullable: true),
            //                    TempDistrictId = table.Column<int>(type: "int", nullable: true),
            //                    TempLatitude = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidTo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Vegetable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    WorkPlaceId = table.Column<int>(type: "int", nullable: true),
            //                    WorkStatusId = table.Column<int>(type: "int", nullable: true),
            //                    WorkStatusName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkStatusOrder = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkStatusText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    YearsOld = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeCTO_Candidate_CandidateId",
            //                        column: x => x.CandidateId,
            //                        principalTable: "Candidate",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeCTO_Employee_TSRecorderId",
            //                        column: x => x.TSRecorderId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeCTO_Employee_TSSubmitterId",
            //                        column: x => x.TSSubmitterId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeCTO_SysEnumElement_BankId",
            //                        column: x => x.BankId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "EmployeeCJKPIHist",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmployeeCJKPIId = table.Column<int>(type: "int", nullable: false),
            //                    AllowSync = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    CJMonth = table.Column<int>(type: "int", nullable: false),
            //                    CJType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJYear = table.Column<int>(type: "int", nullable: false),
            //                    CJetKPILinkedCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJetKPIName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJetScore = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    CJetTarget = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CJetUserName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    ERPScore = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: false),
            //                    EmployeeKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ResponseMessage = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ResponseStatus = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_EmployeeCJKPIHist", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_EmployeeCJKPIHist_EmployeeCJKPI_EmployeeCJKPIId",
            //                        column: x => x.EmployeeCJKPIId,
            //                        principalTable: "EmployeeCJKPI",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialIssueWareHouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CurrencyId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    ExportTypeId = table.Column<int>(type: "int", nullable: true),
            //                    LocationId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsLock = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    RequestWareHouseList = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialIssueWareHouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_Location_LocationId",
            //                        column: x => x.LocationId,
            //                        principalTable: "Location",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_MaterialRequestWareHouse_MaterialRequestWareHouseId",
            //                        column: x => x.MaterialRequestWareHouseId,
            //                        principalTable: "MaterialRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_Supplier_SupplierId",
            //                        column: x => x.SupplierId,
            //                        principalTable: "Supplier",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_SysEnumElement_CurrencyId",
            //                        column: x => x.CurrencyId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_SysEnumElement_ExportTypeId",
            //                        column: x => x.ExportTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouse_Warehouse_WarehouseId",
            //                        column: x => x.WarehouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialOnhandWareHouseRequestLog",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    LocationId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    RequestWareHouseTypeStatusId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierId = table.Column<int>(type: "int", nullable: true),
            //                    SWLId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    BOMCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BOMMaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BookingQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RQQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialOnhandWareHouseRequestLog", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_Location_LocationId",
            //                        column: x => x.LocationId,
            //                        principalTable: "Location",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_MaterialRequestWareHouse_MaterialRequestWareHouseId",
            //                        column: x => x.MaterialRequestWareHouseId,
            //                        principalTable: "MaterialRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_Supplier_SupplierId",
            //                        column: x => x.SupplierId,
            //                        principalTable: "Supplier",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_RequestWareHouseTypeStatusId",
            //                        column: x => x.RequestWareHouseTypeStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_SWLId",
            //                        column: x => x.SWLId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseRequestLog_Warehouse_WarehouseId",
            //                        column: x => x.WarehouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MonthlyAssignmentLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: false),
            //                    LeaderId = table.Column<int>(type: "int", nullable: true),
            //                    MonthlyAssignmentId = table.Column<int>(type: "int", nullable: false),
            //                    BPDivisionId = table.Column<int>(type: "int", nullable: true),
            //                    BPDivisionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    CustomerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmployeeKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    FactoryId = table.Column<int>(type: "int", nullable: true),
            //                    FactoryLineId = table.Column<int>(type: "int", nullable: true),
            //                    FactoryLineName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FactoryName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LeaderKnowAs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MonthlyAssignmentLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignmentLine_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignmentLine_Employee_LeaderId",
            //                        column: x => x.LeaderId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MonthlyAssignmentLine_MonthlyAssignment_MonthlyAssignmentId",
            //                        column: x => x.MonthlyAssignmentId,
            //                        principalTable: "MonthlyAssignment",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingOrder",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    MaterialStatusId = table.Column<int>(type: "int", nullable: true),
            //                    MOStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductionNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductionSection = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingOrder", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrder_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrder_SysEnumElement_MOStatusId",
            //                        column: x => x.MOStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrder_SysEnumElement_MaterialStatusId",
            //                        column: x => x.MaterialStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrder_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductCodeManufacturingHistory",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsUsed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductCodeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductCodeManufacturingHistory", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeManufacturingHistory_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductCodeOrdersHistory",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    ProductCodeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Unit = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductCodeOrdersHistory", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeOrdersHistory_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeOrdersHistory_SalesOrder_SalesOrderId",
            //                        column: x => x.SalesOrderId,
            //                        principalTable: "SalesOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeOrdersHistory_SysEnumElement_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeOrdersHistory_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "QuickOrder",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductCodeGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeLineId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_QuickOrder", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_QuickOrder_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_QuickOrder_SysEnumElement_ProductCodeGroupId",
            //                        column: x => x.ProductCodeGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_QuickOrder_SysEnumElement_ProductCodeLineId",
            //                        column: x => x.ProductCodeLineId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SampleOrder",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    EmPrId = table.Column<int>(type: "int", nullable: true),
            //                    FabricId = table.Column<int>(type: "int", nullable: true),
            //                    FixReasonId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    RequiredFromId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderReferId = table.Column<int>(type: "int", nullable: true),
            //                    SampleTailorTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DesignEmployee = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ProductCodeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderReferSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SampleRequiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SampleOrder", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_Employee_RequiredFromId",
            //                        column: x => x.RequiredFromId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_SampleOrder_SampleOrderReferId",
            //                        column: x => x.SampleOrderReferId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_SysEnumElement_EmPrId",
            //                        column: x => x.EmPrId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_SysEnumElement_FabricId",
            //                        column: x => x.FabricId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_SysEnumElement_FixReasonId",
            //                        column: x => x.FixReasonId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_SysEnumElement_ProductTypeId",
            //                        column: x => x.ProductTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleOrder_SysEnumElement_SampleTailorTypeId",
            //                        column: x => x.SampleTailorTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialOutwardWareHouseLog",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BOMId = table.Column<int>(type: "int", nullable: true),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialIssueWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierId = table.Column<int>(type: "int", nullable: true),
            //                    SWLId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    BOMCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BOMMaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OutwardDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    TotalQuantity = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialOutwardWareHouseLog", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_BOM_BOMId",
            //                        column: x => x.BOMId,
            //                        principalTable: "BOM",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_MaterialIssueWareHouse_MaterialIssueWareHouseId",
            //                        column: x => x.MaterialIssueWareHouseId,
            //                        principalTable: "MaterialIssueWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_Supplier_SupplierId",
            //                        column: x => x.SupplierId,
            //                        principalTable: "Supplier",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_SWLId",
            //                        column: x => x.SWLId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOutwardWareHouseLog_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "InwardOrder",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ApproveEmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    InwardOrderReasonId = table.Column<int>(type: "int", nullable: true),
            //                    InwardOrderTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    OrderTypesId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    ActualIncomeAmount = table.Column<double>(type: "float", nullable: true),
            //                    AdvancePaymentAmount = table.Column<double>(type: "float", nullable: true),
            //                    ApproveEmployeeFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    EmployeeFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InwardOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_InwardOrder", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_Employee_ApproveEmployeeId",
            //                        column: x => x.ApproveEmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_MaterialRequestWareHouse_MaterialRequestWareHouseId",
            //                        column: x => x.MaterialRequestWareHouseId,
            //                        principalTable: "MaterialRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_SysEnumElement_InwardOrderReasonId",
            //                        column: x => x.InwardOrderReasonId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_SysEnumElement_InwardOrderTypeId",
            //                        column: x => x.InwardOrderTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_SysEnumElement_OrderTypesId",
            //                        column: x => x.OrderTypesId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrder_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingOrderBalanceLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MeasurementId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    ActualNorm = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    ActualQuantity = table.Column<double>(type: "float", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    ExpectedNorm = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    GrantedQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HaveQuantity = table.Column<double>(type: "float", nullable: true),
            //                    IsCopy = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderLineId = table.Column<int>(type: "int", nullable: false),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialOnhandWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    MissingQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    NeedQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OrderQuantity = table.Column<int>(type: "int", nullable: true),
            //                    Price = table.Column<decimal>(type: "decimal(28,9)", nullable: false),
            //                    RemainQuantity = table.Column<int>(type: "int", nullable: true),
            //                    ReturnStockQuantity = table.Column<double>(type: "float", nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    StockQuantity = table.Column<double>(type: "float", nullable: true),
            //                    SupplyQuantity = table.Column<double>(type: "float", nullable: true),
            //                    TechnicalNorm = table.Column<decimal>(type: "decimal(28,9)", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingOrderBalanceLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_EnumSizeScaleConfig_MeasurementId",
            //                        column: x => x.MeasurementId,
            //                        principalTable: "EnumSizeScaleConfig",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBalanceLine_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingOrderBomLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MOBalanceTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    ActualNorm = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    ExpectedNorm = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LocationUse = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingOrderBomLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_MOBalanceTypeId",
            //                        column: x => x.MOBalanceTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderBomLine_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingOrderLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    LabelId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MOLineStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionNumberId = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Consignment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDeploy = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OrderQuantity = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductionQuantity = table.Column<int>(type: "int", nullable: true),
            //                    RemainQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    SalesOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingOrderLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderLine_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderLine_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderLine_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderLine_SalesOrderLine_SalesOrderLineId",
            //                        column: x => x.SalesOrderLineId,
            //                        principalTable: "SalesOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderLine_SysEnumElement_LabelId",
            //                        column: x => x.LabelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderLine_SysEnumElement_MOLineStatusId",
            //                        column: x => x.MOLineStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderLine_SysEnumElement_ProductionNumberId",
            //                        column: x => x.ProductionNumberId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingOrderMixingColorLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    FabricId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FabricCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FabricName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingOrderMixingColorLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderMixingColorLine_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderMixingColorLine_Material_FabricId",
            //                        column: x => x.FabricId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingOrderMixingColorLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductionActivity",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionStatusId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductionNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductionSection = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductionActivity", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivity_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivity_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivity_SysEnumElement_MaterialStatusId",
            //                        column: x => x.MaterialStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivity_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivity_SysEnumElement_ProductionStatusId",
            //                        column: x => x.ProductionStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "QuickOrderLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    FabricId = table.Column<int>(type: "int", nullable: true),
            //                    FabricIngredientId = table.Column<int>(type: "int", nullable: false),
            //                    QuickOrderId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HandoverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: false),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_QuickOrderLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_QuickOrderLine_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_QuickOrderLine_QuickOrder_QuickOrderId",
            //                        column: x => x.QuickOrderId,
            //                        principalTable: "QuickOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_QuickOrderLine_SysEnumElement_FabricId",
            //                        column: x => x.FabricId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_QuickOrderLine_SysEnumElement_FabricIngredientId",
            //                        column: x => x.FabricIngredientId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialBookingWareHouseLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    BOMCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderBalanceLineId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialOnhandWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Norm = table.Column<double>(type: "float", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    RequestQuantity = table.Column<double>(type: "float", nullable: true),
            //                    RequireQuantity = table.Column<double>(type: "float", nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    Specification = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialBookingWareHouseLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_MaterialRequestWareHouse_MaterialRequestWareHouseId",
            //                        column: x => x.MaterialRequestWareHouseId,
            //                        principalTable: "MaterialRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialBookingWareHouseLine_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialIssueWareHouseLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialIssueWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialReplacementId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierId = table.Column<int>(type: "int", nullable: true),
            //                    SWLId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InventoryQuantity = table.Column<double>(type: "float", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderBalanceLineId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialOnhandWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    RequestQuantity = table.Column<double>(type: "float", nullable: true),
            //                    SuggestMaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    TotalQuantity = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialIssueWareHouseLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_MaterialIssueWareHouse_MaterialIssueWareHouseId",
            //                        column: x => x.MaterialIssueWareHouseId,
            //                        principalTable: "MaterialIssueWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_Material_MaterialReplacementId",
            //                        column: x => x.MaterialReplacementId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_Supplier_SupplierId",
            //                        column: x => x.SupplierId,
            //                        principalTable: "Supplier",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SysEnumElement_SWLId",
            //                        column: x => x.SWLId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialIssueWareHouseLine_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialOnhandWareHouseLog",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BOMId = table.Column<int>(type: "int", nullable: true),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierId = table.Column<int>(type: "int", nullable: true),
            //                    SWLId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WareHouseTypeStatusId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    BOMCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    BOMMaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialIssueReceiptWareHouseCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialIssueReceiptWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialRequestWareHouseCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    Quantity = table.Column<double>(type: "float", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialOnhandWareHouseLog", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_BOM_BOMId",
            //                        column: x => x.BOMId,
            //                        principalTable: "BOM",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_MaterialRequestWareHouse_MaterialRequestWareHouseId",
            //                        column: x => x.MaterialRequestWareHouseId,
            //                        principalTable: "MaterialRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_Supplier_SupplierId",
            //                        column: x => x.SupplierId,
            //                        principalTable: "Supplier",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_SWLId",
            //                        column: x => x.SWLId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_WareHouseTypeStatusId",
            //                        column: x => x.WareHouseTypeStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialOnhandWareHouseLog_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductCodeDevelopingHistory",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    RequestSideId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    GuidImageSO = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductCodeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderIdRefer = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SampleOrderSysNoRefer = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductCodeDevelopingHistory", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeDevelopingHistory_Customer_RequestSideId",
            //                        column: x => x.RequestSideId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeDevelopingHistory_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeDevelopingHistory_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeDevelopingHistory_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeDevelopingHistory_SysEnumElement_ProductTypeId",
            //                        column: x => x.ProductTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductCodeDevelopingHistory_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductPlan",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BorrowerId = table.Column<int>(type: "int", nullable: true),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    FabricId = table.Column<int>(type: "int", nullable: true),
            //                    FinishedProductStatusId = table.Column<int>(type: "int", nullable: true),
            //                    FixReasonId = table.Column<int>(type: "int", nullable: true),
            //                    ManuBorrowerId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    PrintingEmbroideryStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ReasonId = table.Column<int>(type: "int", nullable: true),
            //                    RequiredFromId = table.Column<int>(type: "int", nullable: true),
            //                    RQBOMStatusId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderReferId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderTypeId = table.Column<int>(type: "int", nullable: true),
            //                    BorrowingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CorrectionFactor = table.Column<float>(type: "real", nullable: true),
            //                    CorrectionLevel = table.Column<float>(type: "real", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FixLocation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FixSampleTimes = table.Column<int>(type: "int", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    GuidImageSO = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsEmPr = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsProcess = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsProductActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturerIdList = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ManufacturerNameList = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    NotePP = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Quantity = table.Column<double>(type: "float", nullable: true),
            //                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SampleCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    SampleOrderReferSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SampleOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SampleRequiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkCoefficient = table.Column<float>(type: "real", nullable: true),
            //                    commentApproved = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    commentComplete = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    commentDoNotPro = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    commentDoPro = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    commentPermanentSample = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    commentRemove = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductPlan", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_Employee_BorrowerId",
            //                        column: x => x.BorrowerId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_Employee_RequiredFromId",
            //                        column: x => x.RequiredFromId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_Manufacturer_ManuBorrowerId",
            //                        column: x => x.ManuBorrowerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SampleOrder_SampleOrderReferId",
            //                        column: x => x.SampleOrderReferId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_FabricId",
            //                        column: x => x.FabricId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_FinishedProductStatusId",
            //                        column: x => x.FinishedProductStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_FixReasonId",
            //                        column: x => x.FixReasonId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_PrintingEmbroideryStatusId",
            //                        column: x => x.PrintingEmbroideryStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_ProductTypeId",
            //                        column: x => x.ProductTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_RQBOMStatusId",
            //                        column: x => x.RQBOMStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_ReasonId",
            //                        column: x => x.ReasonId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlan_SysEnumElement_SampleOrderTypeId",
            //                        column: x => x.SampleOrderTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SampleMaterialLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialIssueWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    ActualUsingQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InPrice = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    InwardQuantity = table.Column<double>(type: "float", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsProcess = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Norm = table.Column<double>(type: "float", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OutwardQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    RemainQuantity = table.Column<double>(type: "float", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    WareHouseId = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SampleMaterialLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_MaterialIssueWareHouse_MaterialIssueWareHouseId",
            //                        column: x => x.MaterialIssueWareHouseId,
            //                        principalTable: "MaterialIssueWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SysEnumElement_MaterialTypeId",
            //                        column: x => x.MaterialTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialLine_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SamplePrice",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    FabricId = table.Column<int>(type: "int", nullable: true),
            //                    PriceStructureId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    RequiredFromId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderCustomerId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    BasePrice = table.Column<double>(type: "float", nullable: false),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    ErrorAllowance = table.Column<double>(type: "float", nullable: false),
            //                    ErrorAllowanceText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FactoryAllowance = table.Column<double>(type: "float", nullable: false),
            //                    FactoryAllowanceText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    GuidImageSO = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MinPrice = table.Column<double>(type: "float", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Profit = table.Column<double>(type: "float", nullable: false),
            //                    ProfitText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SampleCostPrice = table.Column<double>(type: "float", nullable: false),
            //                    SampleOrderProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceReferId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceReferSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SuggestedPrice = table.Column<double>(type: "float", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SamplePrice", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SamplePrice_Customer_SampleOrderCustomerId",
            //                        column: x => x.SampleOrderCustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePrice_Employee_RequiredFromId",
            //                        column: x => x.RequiredFromId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePrice_PriceStructure_PriceStructureId",
            //                        column: x => x.PriceStructureId,
            //                        principalTable: "PriceStructure",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePrice_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePrice_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePrice_SysEnumElement_FabricId",
            //                        column: x => x.FabricId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePrice_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "InwardOrderLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    InwardOrderId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    ActualQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Norms = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    Quantity = table.Column<double>(type: "float", nullable: true),
            //                    RequestOrderGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //                    RequestQuantity = table.Column<double>(type: "float", nullable: true),
            //                    RequireQuantity = table.Column<double>(type: "float", nullable: true),
            //                    SamplerOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Specification = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_InwardOrderLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_InwardOrder_InwardOrderId",
            //                        column: x => x.InwardOrderId,
            //                        principalTable: "InwardOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_SysEnumElement_MaterialTypeId",
            //                        column: x => x.MaterialTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_InwardOrderLine_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialReceiptWareHouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmployeeId = table.Column<int>(type: "int", nullable: true),
            //                    InwardOrderId = table.Column<int>(type: "int", nullable: true),
            //                    LocationId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    ReceiptWareHouseTypeId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    ImportType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsLock = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PaymentTerm = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    RequestWareHouseList = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialReceiptWareHouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_Employee_EmployeeId",
            //                        column: x => x.EmployeeId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_InwardOrder_InwardOrderId",
            //                        column: x => x.InwardOrderId,
            //                        principalTable: "InwardOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_Location_LocationId",
            //                        column: x => x.LocationId,
            //                        principalTable: "Location",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_MaterialRequestWareHouse_MaterialRequestWareHouseId",
            //                        column: x => x.MaterialRequestWareHouseId,
            //                        principalTable: "MaterialRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_SysEnumElement_ReceiptWareHouseTypeId",
            //                        column: x => x.ReceiptWareHouseTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouse_Warehouse_WarehouseId",
            //                        column: x => x.WarehouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingSize",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ColorLabel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ColorSizeQuantity = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    NotAllocate = table.Column<int>(type: "int", nullable: true),
            //                    Quantity = table.Column<double>(type: "float", nullable: true),
            //                    QuantityTypeId = table.Column<int>(type: "int", nullable: false),
            //                    Ratio = table.Column<double>(type: "float", nullable: true),
            //                    Size = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingSize", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingSize_ManufacturingOrderLine_ManufacturingOrderLineId",
            //                        column: x => x.ManufacturingOrderLineId,
            //                        principalTable: "ManufacturingOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingSize_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingPrice",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductionActivitySysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingPrice", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPrice_ProductCode_ProductId",
            //                        column: x => x.ProductId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPrice_ProductionActivity_ProductionActivityId",
            //                        column: x => x.ProductionActivityId,
            //                        principalTable: "ProductionActivity",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPrice_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductionActivityBalanceLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    ActualNorm = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    ActualQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    GrantedQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    NeedQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<decimal>(type: "decimal(28,9)", nullable: false),
            //                    Quantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    TechnicalNorm = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductionActivityBalanceLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityBalanceLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityBalanceLine_ProductionActivity_ProductionActivityId",
            //                        column: x => x.ProductionActivityId,
            //                        principalTable: "ProductionActivity",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityBalanceLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityBalanceLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityBalanceLine_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityBalanceLine_SysEnumElement_MaterialTypeId",
            //                        column: x => x.MaterialTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityBalanceLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductPlanLog",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductPlanId = table.Column<int>(type: "int", nullable: true),
            //                    ProductPlanNewStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ProductPlanOldStatusId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Comment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsProcess = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    IsSystemData = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ReasonId = table.Column<int>(type: "int", nullable: true),
            //                    SampleProductionCost = table.Column<double>(type: "float", nullable: true),
            //                    SampleProgress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    WorkCoefficient = table.Column<float>(type: "real", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductPlanLog", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLog_ProductPlan_ProductPlanId",
            //                        column: x => x.ProductPlanId,
            //                        principalTable: "ProductPlan",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLog_SysEnumElement_ProductPlanNewStatusId",
            //                        column: x => x.ProductPlanNewStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLog_SysEnumElement_ProductPlanOldStatusId",
            //                        column: x => x.ProductPlanOldStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLog_SysEnumElement_SampleOrderTypeId",
            //                        column: x => x.SampleOrderTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductPlanPrintingEmbroidery",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    EmbroideryStatusId = table.Column<int>(type: "int", nullable: true),
            //                    PrintingStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ProductPlanId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    Applique = table.Column<float>(type: "real", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    EmbroideryDetailQuantity = table.Column<float>(type: "real", nullable: true),
            //                    EmbroideryNote = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    EmbroideryPhoneNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    EmbroideryProducingPrice = table.Column<float>(type: "real", nullable: true),
            //                    EmbroideryProducingTotalPrice = table.Column<float>(type: "real", nullable: true),
            //                    EmbroiderySize = table.Column<float>(type: "real", nullable: true),
            //                    EmbroideryStitchesQuantity = table.Column<float>(type: "real", nullable: true),
            //                    EmbroideryUnitId = table.Column<int>(type: "int", nullable: true),
            //                    GarmentDesignPrice = table.Column<float>(type: "real", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Patchwork = table.Column<float>(type: "real", nullable: true),
            //                    PrintingDetailQuantity = table.Column<float>(type: "real", nullable: true),
            //                    PrintingFilmColorQuantity = table.Column<float>(type: "real", nullable: true),
            //                    PrintingNote = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    PrintingPhoneNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    PrintingProducingPrice = table.Column<float>(type: "real", nullable: true),
            //                    PrintingProducingTotalPrice = table.Column<float>(type: "real", nullable: true),
            //                    PrintingSize = table.Column<float>(type: "real", nullable: true),
            //                    PrintingTypeId = table.Column<float>(type: "real", nullable: true),
            //                    PrintingUnitId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ThreadSampleColorQuantity = table.Column<float>(type: "real", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductPlanPrintingEmbroidery", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanPrintingEmbroidery_ProductPlan_ProductPlanId",
            //                        column: x => x.ProductPlanId,
            //                        principalTable: "ProductPlan",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanPrintingEmbroidery_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanPrintingEmbroidery_SysEnumElement_EmbroideryStatusId",
            //                        column: x => x.EmbroideryStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanPrintingEmbroidery_SysEnumElement_PrintingStatusId",
            //                        column: x => x.PrintingStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SaleQuotationLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SaleQuotationId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    Default = table.Column<double>(type: "float", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    QuotationPrice = table.Column<double>(type: "float", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SaleQuotationLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SaleQuotationLine_SaleQuotation_SaleQuotationId",
            //                        column: x => x.SaleQuotationId,
            //                        principalTable: "SaleQuotation",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SaleQuotationLine_SamplePrice_SamplePriceId",
            //                        column: x => x.SamplePriceId,
            //                        principalTable: "SamplePrice",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MaterialReceiptWareHouseLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialReceiptWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    SizeId = table.Column<int>(type: "int", nullable: true),
            //                    SupplierId = table.Column<int>(type: "int", nullable: true),
            //                    SWLId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WidthId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    InwardAmount = table.Column<double>(type: "float", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    PurchaseCost = table.Column<double>(type: "float", nullable: true),
            //                    Remark = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    TotalQuantity = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MaterialReceiptWareHouseLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_MaterialReceiptWareHouse_MaterialReceiptWareHouseId",
            //                        column: x => x.MaterialReceiptWareHouseId,
            //                        principalTable: "MaterialReceiptWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_Supplier_SupplierId",
            //                        column: x => x.SupplierId,
            //                        principalTable: "Supplier",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_ItemTypeId",
            //                        column: x => x.ItemTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_SWLId",
            //                        column: x => x.SWLId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_SizeId",
            //                        column: x => x.SizeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_MaterialReceiptWareHouseLine_SysEnumElement_WidthId",
            //                        column: x => x.WidthId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductionActivityLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    LabelId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderLineId = table.Column<int>(type: "int", nullable: false),
            //                    ManufacturingPriceId = table.Column<int>(type: "int", nullable: true),
            //                    PAStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityId = table.Column<int>(type: "int", nullable: true),
            //                    QCId = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    ActualQuantity = table.Column<int>(type: "int", nullable: true),
            //                    Consignment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    DeliveryQuantity = table.Column<int>(type: "int", nullable: true),
            //                    ErrorComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ErrorQuantity = table.Column<int>(type: "int", nullable: true),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    FinishQuantity = table.Column<int>(type: "int", nullable: false),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    ImportQuantity = table.Column<int>(type: "int", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsLocked = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ManufacturingOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OrderQuantity = table.Column<int>(type: "int", nullable: true),
            //                    Price = table.Column<decimal>(type: "decimal(28,9)", nullable: false),
            //                    ProductionQuantity = table.Column<int>(type: "int", nullable: true),
            //                    ProductionType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    QCName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SalesOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    TPQuantity = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductionActivityLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_Employee_QCId",
            //                        column: x => x.QCId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_ManufacturingOrderLine_ManufacturingOrderLineId",
            //                        column: x => x.ManufacturingOrderLineId,
            //                        principalTable: "ManufacturingOrderLine",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_ManufacturingPrice_ManufacturingPriceId",
            //                        column: x => x.ManufacturingPriceId,
            //                        principalTable: "ManufacturingPrice",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_ProductionActivity_ProductionActivityId",
            //                        column: x => x.ProductionActivityId,
            //                        principalTable: "ProductionActivity",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_SalesOrderLine_SalesOrderLineId",
            //                        column: x => x.SalesOrderLineId,
            //                        principalTable: "SalesOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_SysEnumElement_LabelId",
            //                        column: x => x.LabelId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_SysEnumElement_ManufacturerTypeId",
            //                        column: x => x.ManufacturerTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_SysEnumElement_PAStatusId",
            //                        column: x => x.PAStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLine_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SamplePriceLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturingPriceId = table.Column<int>(type: "int", nullable: true),
            //                    SampleMaterialLineId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Content = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsUse = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Norm = table.Column<double>(type: "float", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    PriceGroupId = table.Column<int>(type: "int", nullable: false),
            //                    PriceGroupSortOrder = table.Column<int>(type: "int", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SamplePriceLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SamplePriceLine_ManufacturingPrice_ManufacturingPriceId",
            //                        column: x => x.ManufacturingPriceId,
            //                        principalTable: "ManufacturingPrice",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePriceLine_SampleMaterialLine_SampleMaterialLineId",
            //                        column: x => x.SampleMaterialLineId,
            //                        principalTable: "SampleMaterialLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePriceLine_SamplePrice_SamplePriceId",
            //                        column: x => x.SamplePriceId,
            //                        principalTable: "SamplePrice",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SamplePriceLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductPlanLogCoefficient",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingDetailId = table.Column<int>(type: "int", nullable: true),
            //                    ProductPlanId = table.Column<int>(type: "int", nullable: true),
            //                    ProductPlanLogId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderTypeId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Coefficient = table.Column<double>(type: "float", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FixLocationContent = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FixLocationId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    FixLocationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    SampleProductionCost = table.Column<double>(type: "float", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    isMultipleFixLocation = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductPlanLogCoefficient", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLogCoefficient_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLogCoefficient_ManufacturingDetail_ManufacturingDetailId",
            //                        column: x => x.ManufacturingDetailId,
            //                        principalTable: "ManufacturingDetail",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLogCoefficient_ProductPlanLog_ProductPlanLogId",
            //                        column: x => x.ProductPlanLogId,
            //                        principalTable: "ProductPlanLog",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLogCoefficient_ProductPlan_ProductPlanId",
            //                        column: x => x.ProductPlanId,
            //                        principalTable: "ProductPlan",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLogCoefficient_SysEnumElement_ManufacturerTypeId",
            //                        column: x => x.ManufacturerTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductPlanLogCoefficient_SysEnumElement_SampleOrderTypeId",
            //                        column: x => x.SampleOrderTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "DeliveryManagement",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    SaleOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    ActualQuantity = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Consignment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    DeliveryPercent = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    DeliveryQuantity = table.Column<int>(type: "int", nullable: true),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    GrantQuantity = table.Column<int>(type: "int", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    ImportQuantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsLocked = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    OrderQuantity = table.Column<int>(type: "int", nullable: true),
            //                    PaymentPercent = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    ProductionActivitySysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    RemainQuantity = table.Column<int>(type: "int", nullable: true),
            //                    SaleOrderSysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_DeliveryManagement", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagement_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagement_ManufacturingOrderLine_ManufacturingOrderLineId",
            //                        column: x => x.ManufacturingOrderLineId,
            //                        principalTable: "ManufacturingOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagement_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagement_SalesOrderLine_SaleOrderLineId",
            //                        column: x => x.SaleOrderLineId,
            //                        principalTable: "SalesOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagement_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ManufacturingPriceLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ConfirmEmpId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingPriceId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingPriceTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    Amount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    ConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ConfirmEmpName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Consigment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Content = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsUsed = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialUsageQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ProductingQuantity = table.Column<double>(type: "float", nullable: true),
            //                    ProductionActivityBalanceId = table.Column<int>(type: "int", nullable: true),
            //                    Quantity = table.Column<double>(type: "float", nullable: true),
            //                    TechnicalNorm = table.Column<double>(type: "float", nullable: true),
            //                    UnitPrice = table.Column<decimal>(type: "decimal(28,9)", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ManufacturingPriceLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPriceLine_Employee_ConfirmEmpId",
            //                        column: x => x.ConfirmEmpId,
            //                        principalTable: "Employee",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPriceLine_ManufacturingPrice_ManufacturingPriceId",
            //                        column: x => x.ManufacturingPriceId,
            //                        principalTable: "ManufacturingPrice",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPriceLine_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPriceLine_SysEnumElement_ManufacturingPriceTypeId",
            //                        column: x => x.ManufacturingPriceTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ManufacturingPriceLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductionActivityAccessoriesSupply",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ColorId = table.Column<int>(type: "int", nullable: true),
            //                    ContentId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingPriceId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialGroupId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityBalanceLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true),
            //                    SupplyQuantity = table.Column<double>(type: "float", nullable: true),
            //                    TechnicalNorm = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductionActivityAccessoriesSupply", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_ManufacturingPrice_ManufacturingPriceId",
            //                        column: x => x.ManufacturingPriceId,
            //                        principalTable: "ManufacturingPrice",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_ProductionActivityBalanceLine_ProductionActivityBalanceLineId",
            //                        column: x => x.ProductionActivityBalanceLineId,
            //                        principalTable: "ProductionActivityBalanceLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_ProductionActivity_ProductionActivityId",
            //                        column: x => x.ProductionActivityId,
            //                        principalTable: "ProductionActivity",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_SysEnumElement_ColorId",
            //                        column: x => x.ColorId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_SysEnumElement_ContentId",
            //                        column: x => x.ContentId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_SysEnumElement_MaterialGroupId",
            //                        column: x => x.MaterialGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_SysEnumElement_MaterialTypeId",
            //                        column: x => x.MaterialTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityAccessoriesSupply_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductionActivityLineHistory",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: false),
            //                    Action = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DateProcessing = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    DeliveryQuantity = table.Column<int>(type: "int", nullable: true),
            //                    ErrorComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ErrorQuantity = table.Column<int>(type: "int", nullable: true),
            //                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    FromStatus = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    No = table.Column<int>(type: "int", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ProductionQuantity = table.Column<int>(type: "int", nullable: true),
            //                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    TPQuantity = table.Column<int>(type: "int", nullable: true),
            //                    ToStatus = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductionActivityLineHistory", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLineHistory_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityLineHistory_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id",
            //                        onDelete: ReferentialAction.Cascade);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductionActivitySizeColor",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductionActivityId = table.Column<int>(type: "int", nullable: true),
            //                    ColorSizeQuantity = table.Column<int>(type: "int", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ManufacturingSizeId = table.Column<int>(type: "int", nullable: true),
            //                    NotAllocate = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    Quantity = table.Column<double>(type: "float", nullable: true),
            //                    QuantityTypeId = table.Column<int>(type: "int", nullable: false),
            //                    Ratio = table.Column<double>(type: "float", nullable: true),
            //                    Size = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SortOrder = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductionActivitySizeColor", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivitySizeColor_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivitySizeColor_ProductionActivity_ProductionActivityId",
            //                        column: x => x.ProductionActivityId,
            //                        principalTable: "ProductionActivity",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductRequestWareHouseLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    LocationId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    RequestStatusId = table.Column<int>(type: "int", nullable: true),
            //                    RequestTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Consignment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HandOverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    Priority = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    ProductName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderQuantity = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    TotalQuantity = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductRequestWareHouseLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_Location_LocationId",
            //                        column: x => x.LocationId,
            //                        principalTable: "Location",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_ManufacturingOrderLine_ManufacturingOrderLineId",
            //                        column: x => x.ManufacturingOrderLineId,
            //                        principalTable: "ManufacturingOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_ProductRequestWareHouse_ProductRequestWareHouseId",
            //                        column: x => x.ProductRequestWareHouseId,
            //                        principalTable: "ProductRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_SysEnumElement_ProductTypeId",
            //                        column: x => x.ProductTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_SysEnumElement_RequestStatusId",
            //                        column: x => x.RequestStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_SysEnumElement_RequestTypeId",
            //                        column: x => x.RequestTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductRequestWareHouseLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SampleCost",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    BOMId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialId = table.Column<int>(type: "int", nullable: true),
            //                    ProductPlanId = table.Column<int>(type: "int", nullable: true),
            //                    ProductPlanLogCoefficientId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Content = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Cost = table.Column<double>(type: "float", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Norm = table.Column<double>(type: "float", nullable: false),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: false),
            //                    PriceGroupId = table.Column<int>(type: "int", nullable: false),
            //                    PriceGroupSortOrder = table.Column<int>(type: "int", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SampleCost", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SampleCost_BOM_BOMId",
            //                        column: x => x.BOMId,
            //                        principalTable: "BOM",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleCost_Manufacturer_ManufacturerId",
            //                        column: x => x.ManufacturerId,
            //                        principalTable: "Manufacturer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleCost_Material_MaterialId",
            //                        column: x => x.MaterialId,
            //                        principalTable: "Material",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleCost_ProductPlanLogCoefficient_ProductPlanLogCoefficientId",
            //                        column: x => x.ProductPlanLogCoefficientId,
            //                        principalTable: "ProductPlanLogCoefficient",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleCost_ProductPlan_ProductPlanId",
            //                        column: x => x.ProductPlanId,
            //                        principalTable: "ProductPlan",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleCost_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleCost_SamplePrice_SamplePriceId",
            //                        column: x => x.SamplePriceId,
            //                        principalTable: "SamplePrice",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SampleMaterialPriceLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ProductPlanLogCoefficientId = table.Column<int>(type: "int", nullable: true),
            //                    SampleMaterialLineId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Content = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsCopy = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    IsUse = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Norm = table.Column<double>(type: "float", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    PriceGroupId = table.Column<int>(type: "int", nullable: false),
            //                    PriceGroupSortOrder = table.Column<int>(type: "int", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SampleMaterialPriceLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialPriceLine_ProductPlanLogCoefficient_ProductPlanLogCoefficientId",
            //                        column: x => x.ProductPlanLogCoefficientId,
            //                        principalTable: "ProductPlanLogCoefficient",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialPriceLine_SampleMaterialLine_SampleMaterialLineId",
            //                        column: x => x.SampleMaterialLineId,
            //                        principalTable: "SampleMaterialLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialPriceLine_SamplePrice_SamplePriceId",
            //                        column: x => x.SamplePriceId,
            //                        principalTable: "SamplePrice",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_SampleMaterialPriceLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "DeliveryManagementLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    DeliveryManagementId = table.Column<int>(type: "int", nullable: true),
            //                    DeliveryTypeId = table.Column<int>(type: "int", nullable: true),
            //                    DeliveryUnitId = table.Column<int>(type: "int", nullable: true),
            //                    ProductExportWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    ProductRequestWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    StatusId = table.Column<int>(type: "int", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    Quantity = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_DeliveryManagementLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagementLine_DeliveryManagement_DeliveryManagementId",
            //                        column: x => x.DeliveryManagementId,
            //                        principalTable: "DeliveryManagement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagementLine_ProductExportWareHouse_ProductExportWareHouseId",
            //                        column: x => x.ProductExportWareHouseId,
            //                        principalTable: "ProductExportWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagementLine_ProductRequestWareHouse_ProductRequestWareHouseId",
            //                        column: x => x.ProductRequestWareHouseId,
            //                        principalTable: "ProductRequestWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagementLine_SysEnumElement_DeliveryTypeId",
            //                        column: x => x.DeliveryTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagementLine_SysEnumElement_DeliveryUnitId",
            //                        column: x => x.DeliveryUnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_DeliveryManagementLine_SysEnumElement_StatusId",
            //                        column: x => x.StatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductionActivityDetailLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturingTypeId = table.Column<int>(type: "int", nullable: true),
            //                    MaterialTypeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityAccessoriesSupplyId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    AccessoriesUsingQuantity = table.Column<double>(type: "float", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    FinishQuantity = table.Column<double>(type: "float", nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    MaterialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TechnicalNorm = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductionActivityDetailLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityDetailLine_ProductionActivityAccessoriesSupply_ProductionActivityAccessoriesSupplyId",
            //                        column: x => x.ProductionActivityAccessoriesSupplyId,
            //                        principalTable: "ProductionActivityAccessoriesSupply",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityDetailLine_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityDetailLine_ProductionActivity_ProductionActivityId",
            //                        column: x => x.ProductionActivityId,
            //                        principalTable: "ProductionActivity",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityDetailLine_SysEnumElement_ManufacturingTypeId",
            //                        column: x => x.ManufacturingTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityDetailLine_SysEnumElement_MaterialTypeId",
            //                        column: x => x.MaterialTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductionActivityDetailLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductInventoryWareHouse",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    ManufacturingOrderId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductRequestWareHouseLineId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Consignment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    Image = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    InwardAmount = table.Column<double>(type: "float", nullable: true),
            //                    InwardQuantity = table.Column<int>(type: "int", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    OutwardAmount = table.Column<double>(type: "float", nullable: true),
            //                    OutwardQuantity = table.Column<int>(type: "int", nullable: true),
            //                    PaymentAmount = table.Column<double>(type: "float", nullable: false),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ProductCodeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SamplePriceId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalInventory = table.Column<int>(type: "int", nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    TotalQuantity = table.Column<int>(type: "int", nullable: true),
            //                    WarehouseName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductInventoryWareHouse", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouse_ManufacturingOrder_ManufacturingOrderId",
            //                        column: x => x.ManufacturingOrderId,
            //                        principalTable: "ManufacturingOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouse_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouse_ProductRequestWareHouseLine_ProductRequestWareHouseLineId",
            //                        column: x => x.ProductRequestWareHouseLineId,
            //                        principalTable: "ProductRequestWareHouseLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouse_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouse_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouse_Warehouse_WarehouseId",
            //                        column: x => x.WarehouseId,
            //                        principalTable: "Warehouse",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductExportWareHouseLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    ExportStatusId = table.Column<int>(type: "int", nullable: true),
            //                    ExportTypeId = table.Column<int>(type: "int", nullable: true),
            //                    LocationId = table.Column<int>(type: "int", nullable: true),
            //                    ManufacturingOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductExportWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
            //                    ProductInventoryWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Consignment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    DiscountAmount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    FinalProductCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HandOverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    InventoryQuantity = table.Column<int>(type: "int", nullable: true),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //                    Price = table.Column<double>(type: "float", nullable: true),
            //                    PriceProgram = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
            //                    Priority = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
            //                    ProductName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    SalesOrderId = table.Column<int>(type: "int", nullable: true),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    TotalPrice = table.Column<double>(type: "float", nullable: true),
            //                    TotalQuantity = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductExportWareHouseLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_Location_LocationId",
            //                        column: x => x.LocationId,
            //                        principalTable: "Location",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_ManufacturingOrderLine_ManufacturingOrderLineId",
            //                        column: x => x.ManufacturingOrderLineId,
            //                        principalTable: "ManufacturingOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_ProductExportWareHouse_ProductExportWareHouseId",
            //                        column: x => x.ProductExportWareHouseId,
            //                        principalTable: "ProductExportWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_ProductInventoryWareHouse_ProductInventoryWareHouseId",
            //                        column: x => x.ProductInventoryWareHouseId,
            //                        principalTable: "ProductInventoryWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_SysEnumElement_ExportStatusId",
            //                        column: x => x.ExportStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_SysEnumElement_ExportTypeId",
            //                        column: x => x.ExportTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_SysEnumElement_ProductGroupId",
            //                        column: x => x.ProductGroupId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_SysEnumElement_ProductTypeId",
            //                        column: x => x.ProductTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductExportWareHouseLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "ProductInventoryWareHouseLine",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    CustomerId = table.Column<int>(type: "int", nullable: true),
            //                    LocationId = table.Column<int>(type: "int", nullable: true),
            //                    ProductCodeId = table.Column<int>(type: "int", nullable: true),
            //                    ProductInventoryWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    ProductionActivityLineId = table.Column<int>(type: "int", nullable: true),
            //                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //                    SalesOrderLineId = table.Column<int>(type: "int", nullable: true),
            //                    SampleOrderId = table.Column<int>(type: "int", nullable: true),
            //                    UnitId = table.Column<int>(type: "int", nullable: true),
            //                    WareHouseTypeStatusId = table.Column<int>(type: "int", nullable: true),
            //                    Code = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
            //                    HandOverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    InvoiceAmount = table.Column<double>(type: "float", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
            //                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    LocationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //                    ProductImportExportWareHouseCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    ProductImportExportWareHouseId = table.Column<int>(type: "int", nullable: true),
            //                    Quantity = table.Column<int>(type: "int", nullable: true),
            //                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    SysNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //                    UnitPrice = table.Column<double>(type: "float", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_ProductInventoryWareHouseLine", x => x.Id);
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_Customer_CustomerId",
            //                        column: x => x.CustomerId,
            //                        principalTable: "Customer",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_Location_LocationId",
            //                        column: x => x.LocationId,
            //                        principalTable: "Location",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_ProductCode_ProductCodeId",
            //                        column: x => x.ProductCodeId,
            //                        principalTable: "ProductCode",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_ProductInventoryWareHouse_ProductInventoryWareHouseId",
            //                        column: x => x.ProductInventoryWareHouseId,
            //                        principalTable: "ProductInventoryWareHouse",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_ProductionActivityLine_ProductionActivityLineId",
            //                        column: x => x.ProductionActivityLineId,
            //                        principalTable: "ProductionActivityLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_SalesOrderLine_SalesOrderLineId",
            //                        column: x => x.SalesOrderLineId,
            //                        principalTable: "SalesOrderLine",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_SampleOrder_SampleOrderId",
            //                        column: x => x.SampleOrderId,
            //                        principalTable: "SampleOrder",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_SysEnumElement_ProductTypeId",
            //                        column: x => x.ProductTypeId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_SysEnumElement_UnitId",
            //                        column: x => x.UnitId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                    table.ForeignKey(
            //                        name: "FK_ProductInventoryWareHouseLine_SysEnumElement_WareHouseTypeStatusId",
            //                        column: x => x.WareHouseTypeStatusId,
            //                        principalTable: "SysEnumElement",
            //                        principalColumn: "Id");
            //                });

            //            migrationBuilder.CreateIndex(
            //                name: "IX_AspNetUsers_EmployeeId",
            //                table: "AspNetUsers",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Attachment_CategoryId",
            //                table: "Attachment",
            //                column: "CategoryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Attachment_EmployeeId",
            //                table: "Attachment",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_AuditEntryProperty_AuditEntryID",
            //                table: "AuditEntryProperty",
            //                column: "AuditEntryID");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BankAccount_BankBrandId",
            //                table: "BankAccount",
            //                column: "BankBrandId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BankAccount_BankId",
            //                table: "BankAccount",
            //                column: "BankId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_BOMMaterialReplacementId",
            //                table: "BOM",
            //                column: "BOMMaterialReplacementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_ColorId",
            //                table: "BOM",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_ContentId",
            //                table: "BOM",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_ItemTypeId",
            //                table: "BOM",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_MaterialGroupId",
            //                table: "BOM",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_MaterialId",
            //                table: "BOM",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_MaterialReplacementId",
            //                table: "BOM",
            //                column: "MaterialReplacementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_SampleOrderId",
            //                table: "BOM",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_SizeId",
            //                table: "BOM",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_SWLId",
            //                table: "BOM",
            //                column: "SWLId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_UnitId",
            //                table: "BOM",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BOM_WidthId",
            //                table: "BOM",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_AccountCodeId",
            //                table: "BusinessPartner",
            //                column: "AccountCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_BusinessPartnerGroupId",
            //                table: "BusinessPartner",
            //                column: "BusinessPartnerGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_ChannelId",
            //                table: "BusinessPartner",
            //                column: "ChannelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_CityId",
            //                table: "BusinessPartner",
            //                column: "CityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_CountryId",
            //                table: "BusinessPartner",
            //                column: "CountryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_DeliveryTermId",
            //                table: "BusinessPartner",
            //                column: "DeliveryTermId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_IncoTermId",
            //                table: "BusinessPartner",
            //                column: "IncoTermId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_MarketId",
            //                table: "BusinessPartner",
            //                column: "MarketId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_MarketLevelId",
            //                table: "BusinessPartner",
            //                column: "MarketLevelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_ParentId",
            //                table: "BusinessPartner",
            //                column: "ParentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_PaymentTermId",
            //                table: "BusinessPartner",
            //                column: "PaymentTermId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_RegionId",
            //                table: "BusinessPartner",
            //                column: "RegionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_SectorId",
            //                table: "BusinessPartner",
            //                column: "SectorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_SegmentId",
            //                table: "BusinessPartner",
            //                column: "SegmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessPartner_TermOfDeliveryId",
            //                table: "BusinessPartner",
            //                column: "TermOfDeliveryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessUnit_BULevelId",
            //                table: "BusinessUnit",
            //                column: "BULevelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessUnit_CompanyId",
            //                table: "BusinessUnit",
            //                column: "CompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessUnit_DepartmentId",
            //                table: "BusinessUnit",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessUnit_DivisionId",
            //                table: "BusinessUnit",
            //                column: "DivisionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessUnit_HeadEmpId",
            //                table: "BusinessUnit",
            //                column: "HeadEmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BusinessUnit_ReportToBUId",
            //                table: "BusinessUnit",
            //                column: "ReportToBUId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_BzTripPlace_WorkTypeId",
            //                table: "BzTripPlace",
            //                column: "WorkTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_EduLevelId",
            //                table: "Candidate",
            //                column: "EduLevelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_EduTypeId",
            //                table: "Candidate",
            //                column: "EduTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_EmpId1",
            //                table: "Candidate",
            //                column: "EmpId1");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_GenderId",
            //                table: "Candidate",
            //                column: "GenderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_HomeCityId",
            //                table: "Candidate",
            //                column: "HomeCityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_HomeDistrictId",
            //                table: "Candidate",
            //                column: "HomeDistrictId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_MarritalStatusId",
            //                table: "Candidate",
            //                column: "MarritalStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_NationalityId",
            //                table: "Candidate",
            //                column: "NationalityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_SourceId",
            //                table: "Candidate",
            //                column: "SourceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_TempCityId",
            //                table: "Candidate",
            //                column: "TempCityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Candidate_TempDistrictId",
            //                table: "Candidate",
            //                column: "TempDistrictId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_CheckIn_EmpId",
            //                table: "CheckIn",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_CustomerCompanyId",
            //                table: "Customer",
            //                column: "CustomerCompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_CustomerGroupId",
            //                table: "Customer",
            //                column: "CustomerGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_CustomerTypeId",
            //                table: "Customer",
            //                column: "CustomerTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_DistrictId",
            //                table: "Customer",
            //                column: "DistrictId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_Name",
            //                table: "Customer",
            //                column: "Name",
            //                unique: true,
            //                filter: "[Name] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_PaymentMenthodId",
            //                table: "Customer",
            //                column: "PaymentMenthodId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_ProvinceId",
            //                table: "Customer",
            //                column: "ProvinceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Customer_WardId",
            //                table: "Customer",
            //                column: "WardId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_CustomerType_CusTypeId_OwnerGuid",
            //                table: "CustomerType",
            //                columns: new[] { "CusTypeId", "OwnerGuid" },
            //                unique: true,
            //                filter: "[CusTypeId] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagement_CustomerId",
            //                table: "DeliveryManagement",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagement_ManufacturingOrderLineId",
            //                table: "DeliveryManagement",
            //                column: "ManufacturingOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagement_ProductionActivityLineId",
            //                table: "DeliveryManagement",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagement_SaleOrderLineId",
            //                table: "DeliveryManagement",
            //                column: "SaleOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagement_StatusId",
            //                table: "DeliveryManagement",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagementLine_DeliveryManagementId",
            //                table: "DeliveryManagementLine",
            //                column: "DeliveryManagementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagementLine_DeliveryTypeId",
            //                table: "DeliveryManagementLine",
            //                column: "DeliveryTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagementLine_DeliveryUnitId",
            //                table: "DeliveryManagementLine",
            //                column: "DeliveryUnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagementLine_ProductExportWareHouseId",
            //                table: "DeliveryManagementLine",
            //                column: "ProductExportWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagementLine_ProductRequestWareHouseId",
            //                table: "DeliveryManagementLine",
            //                column: "ProductRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_DeliveryManagementLine_StatusId",
            //                table: "DeliveryManagementLine",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpActivityLog_EmpId",
            //                table: "EmpActivityLog",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpAllowance_AllowanceTypeId",
            //                table: "EmpAllowance",
            //                column: "AllowanceTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpAllowance_EmpId",
            //                table: "EmpAllowance",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpAllowance_SupportFeeId1",
            //                table: "EmpAllowance",
            //                column: "SupportFeeId1");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpDependent_EmpId",
            //                table: "EmpDependent",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpDependent_GenderId",
            //                table: "EmpDependent",
            //                column: "GenderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpDependent_RelationTypeId",
            //                table: "EmpDependent",
            //                column: "RelationTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpEducation_EduLevelId",
            //                table: "EmpEducation",
            //                column: "EduLevelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpEducation_EduTypeId",
            //                table: "EmpEducation",
            //                column: "EduTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpEducation_EmpId",
            //                table: "EmpEducation",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpFamily_EmpId",
            //                table: "EmpFamily",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpFamily_GenderId",
            //                table: "EmpFamily",
            //                column: "GenderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpFamily_RelationTypeId",
            //                table: "EmpFamily",
            //                column: "RelationTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpHobby_EmpId",
            //                table: "EmpHobby",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpHobby_HobbyId",
            //                table: "EmpHobby",
            //                column: "HobbyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_BankId",
            //                table: "Employee",
            //                column: "BankId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_BloodTypeId",
            //                table: "Employee",
            //                column: "BloodTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_CompanyId",
            //                table: "Employee",
            //                column: "CompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_DelegateeId",
            //                table: "Employee",
            //                column: "DelegateeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_DepartmentId",
            //                table: "Employee",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_DivisionId",
            //                table: "Employee",
            //                column: "DivisionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_GenderId",
            //                table: "Employee",
            //                column: "GenderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_HomeCityId",
            //                table: "Employee",
            //                column: "HomeCityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_HomeDistrictId",
            //                table: "Employee",
            //                column: "HomeDistrictId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_LeaveApproverId",
            //                table: "Employee",
            //                column: "LeaveApproverId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_MarritalStatusId",
            //                table: "Employee",
            //                column: "MarritalStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_NationalityId",
            //                table: "Employee",
            //                column: "NationalityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_PositionId",
            //                table: "Employee",
            //                column: "PositionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_ReportToEmpId",
            //                table: "Employee",
            //                column: "ReportToEmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_TeamId",
            //                table: "Employee",
            //                column: "TeamId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_TempCityId",
            //                table: "Employee",
            //                column: "TempCityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_TempDistrictId",
            //                table: "Employee",
            //                column: "TempDistrictId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_TSApproverId",
            //                table: "Employee",
            //                column: "TSApproverId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_TSRecorderId",
            //                table: "Employee",
            //                column: "TSRecorderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_TSSubmitterId",
            //                table: "Employee",
            //                column: "TSSubmitterId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_WorkPlaceId",
            //                table: "Employee",
            //                column: "WorkPlaceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Employee_WorkStatusId",
            //                table: "Employee",
            //                column: "WorkStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeCJKPI_EmployeeId",
            //                table: "EmployeeCJKPI",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeCJKPIHist_EmployeeCJKPIId",
            //                table: "EmployeeCJKPIHist",
            //                column: "EmployeeCJKPIId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeCTO_BankId",
            //                table: "EmployeeCTO",
            //                column: "BankId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeCTO_CandidateId",
            //                table: "EmployeeCTO",
            //                column: "CandidateId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeCTO_TSRecorderId",
            //                table: "EmployeeCTO",
            //                column: "TSRecorderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeCTO_TSSubmitterId",
            //                table: "EmployeeCTO",
            //                column: "TSSubmitterId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeGroup_EmpGroupTypeId",
            //                table: "EmployeeGroup",
            //                column: "EmpGroupTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeGroupMapping_EmployeeGroupId",
            //                table: "EmployeeGroupMapping",
            //                column: "EmployeeGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmployeeGroupMapping_EmployeeId",
            //                table: "EmployeeGroupMapping",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpSubordinate_EmpId",
            //                table: "EmpSubordinate",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpSubordinate_SubId",
            //                table: "EmpSubordinate",
            //                column: "SubId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpTaxInsurance_CardTypeId",
            //                table: "EmpTaxInsurance",
            //                column: "CardTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpTaxInsurance_EmpId",
            //                table: "EmpTaxInsurance",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpTrainingActivity_ApproverId",
            //                table: "EmpTrainingActivity",
            //                column: "ApproverId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpTrainingActivity_EmpId",
            //                table: "EmpTrainingActivity",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpTrainingActivity_SubmiterId",
            //                table: "EmpTrainingActivity",
            //                column: "SubmiterId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkContract_ContractTypeId",
            //                table: "EmpWorkContract",
            //                column: "ContractTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkContract_EmpId",
            //                table: "EmpWorkContract",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkExp_EmpId",
            //                table: "EmpWorkExp",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_CompanyId",
            //                table: "EmpWorkHist",
            //                column: "CompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_DepartmentId",
            //                table: "EmpWorkHist",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_DivisionId",
            //                table: "EmpWorkHist",
            //                column: "DivisionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_EmpId",
            //                table: "EmpWorkHist",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_PositionId",
            //                table: "EmpWorkHist",
            //                column: "PositionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_ReportToEmpId",
            //                table: "EmpWorkHist",
            //                column: "ReportToEmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_TeamId",
            //                table: "EmpWorkHist",
            //                column: "TeamId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_WorkHistTypeId",
            //                table: "EmpWorkHist",
            //                column: "WorkHistTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_WorkPlaceId",
            //                table: "EmpWorkHist",
            //                column: "WorkPlaceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkHist_WorkStatusId",
            //                table: "EmpWorkHist",
            //                column: "WorkStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkingDay_EmpId",
            //                table: "EmpWorkingDay",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkingDay_WorkingDayId",
            //                table: "EmpWorkingDay",
            //                column: "WorkingDayId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EmpWorkingDay_WorkTypeId",
            //                table: "EmpWorkingDay",
            //                column: "WorkTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumManufacturingGroupByTypeConfig_ManufacturingTypeId",
            //                table: "EnumManufacturingGroupByTypeConfig",
            //                column: "ManufacturingTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumManufacturingGroupByTypeConfig_SysEnumElementId",
            //                table: "EnumManufacturingGroupByTypeConfig",
            //                column: "SysEnumElementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumMaterialTypeByCompositionConfig_CompositionId",
            //                table: "EnumMaterialTypeByCompositionConfig",
            //                column: "CompositionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumMaterialTypeByCompositionConfig_SysEnumElementId",
            //                table: "EnumMaterialTypeByCompositionConfig",
            //                column: "SysEnumElementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumMaterialTypeByUnitConfig_SysEnumElementId",
            //                table: "EnumMaterialTypeByUnitConfig",
            //                column: "SysEnumElementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumMaterialTypeByUnitConfig_UnitId",
            //                table: "EnumMaterialTypeByUnitConfig",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumMOBalanceTypeLineConfig_MaterialTypeId",
            //                table: "EnumMOBalanceTypeLineConfig",
            //                column: "MaterialTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EnumSizeScaleConfig_SysEnumElementId",
            //                table: "EnumSizeScaleConfig",
            //                column: "SysEnumElementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDField_EQDLookupFieldId",
            //                table: "EQDField",
            //                column: "EQDLookupFieldId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDField_EQDTableId",
            //                table: "EQDField",
            //                column: "EQDTableId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDFieldValidation_EQDFieldId",
            //                table: "EQDFieldValidation",
            //                column: "EQDFieldId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDJoinStatement_EQDQueryId",
            //                table: "EQDJoinStatement",
            //                column: "EQDQueryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDQuery_SysObjectId",
            //                table: "EQDQuery",
            //                column: "SysObjectId",
            //                unique: true,
            //                filter: "[SysObjectId] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDQueryTable_EQDQueryId",
            //                table: "EQDQueryTable",
            //                column: "EQDQueryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDQueryTable_EQDTableId",
            //                table: "EQDQueryTable",
            //                column: "EQDTableId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDSelectFieldStatement_EQDFieldId",
            //                table: "EQDSelectFieldStatement",
            //                column: "EQDFieldId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDSelectFieldStatement_EQDQueryId",
            //                table: "EQDSelectFieldStatement",
            //                column: "EQDQueryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDSortOrderStatement_EQDQueryId",
            //                table: "EQDSortOrderStatement",
            //                column: "EQDQueryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDSortOrderStatement_EQDSelectFieldStatementId",
            //                table: "EQDSortOrderStatement",
            //                column: "EQDSelectFieldStatementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDWhereStatement_EQDQueryId",
            //                table: "EQDWhereStatement",
            //                column: "EQDQueryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDWhereStatement_EQDSelectFieldStatementId",
            //                table: "EQDWhereStatement",
            //                column: "EQDSelectFieldStatementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_EQDWhereStatement_ParentEQDWhereStatementId",
            //                table: "EQDWhereStatement",
            //                column: "ParentEQDWhereStatementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Images_CategoryId",
            //                table: "Images",
            //                column: "CategoryId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_ApproveEmployeeId",
            //                table: "InwardOrder",
            //                column: "ApproveEmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_EmployeeId",
            //                table: "InwardOrder",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_InwardOrderReasonId",
            //                table: "InwardOrder",
            //                column: "InwardOrderReasonId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_InwardOrderTypeId",
            //                table: "InwardOrder",
            //                column: "InwardOrderTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_ManufacturingOrderId",
            //                table: "InwardOrder",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_MaterialRequestWareHouseId",
            //                table: "InwardOrder",
            //                column: "MaterialRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_OrderTypesId",
            //                table: "InwardOrder",
            //                column: "OrderTypesId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrder_StatusId",
            //                table: "InwardOrder",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_ColorId",
            //                table: "InwardOrderLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_ContentId",
            //                table: "InwardOrderLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_InwardOrderId",
            //                table: "InwardOrderLine",
            //                column: "InwardOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_ManufacturingOrderId",
            //                table: "InwardOrderLine",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_MaterialTypeId",
            //                table: "InwardOrderLine",
            //                column: "MaterialTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_SampleOrderId",
            //                table: "InwardOrderLine",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_SizeId",
            //                table: "InwardOrderLine",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_UnitId",
            //                table: "InwardOrderLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_InwardOrderLine_WidthId",
            //                table: "InwardOrderLine",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Manufacturer_ManufacturerCompanyId",
            //                table: "Manufacturer",
            //                column: "ManufacturerCompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Manufacturer_Name",
            //                table: "Manufacturer",
            //                column: "Name",
            //                unique: true,
            //                filter: "[Name] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Manufacturer_PartnerTypeId",
            //                table: "Manufacturer",
            //                column: "PartnerTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Manufacturer_PaymentMenthodId",
            //                table: "Manufacturer",
            //                column: "PaymentMenthodId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturerType_PartnerTypeId_OwnerGuid",
            //                table: "ManufacturerType",
            //                columns: new[] { "PartnerTypeId", "OwnerGuid" },
            //                unique: true);

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Manufacturing_ProductGroupId",
            //                table: "Manufacturing",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingCoefficient_ManufacturingId",
            //                table: "ManufacturingCoefficient",
            //                column: "ManufacturingId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingCoefficient_ProductGroupId",
            //                table: "ManufacturingCoefficient",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingDetail_ManufacturerId",
            //                table: "ManufacturingDetail",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingDetail_ManufacturerTypeId",
            //                table: "ManufacturingDetail",
            //                column: "ManufacturerTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingDetail_ManufacturingGroupId",
            //                table: "ManufacturingDetail",
            //                column: "ManufacturingGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingDetail_ManufacturingId",
            //                table: "ManufacturingDetail",
            //                column: "ManufacturingId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrder_MaterialStatusId",
            //                table: "ManufacturingOrder",
            //                column: "MaterialStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrder_MOStatusId",
            //                table: "ManufacturingOrder",
            //                column: "MOStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrder_ProductCodeId",
            //                table: "ManufacturingOrder",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrder_ProductGroupId",
            //                table: "ManufacturingOrder",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_ColorId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_ContentId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_ItemTypeId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_ManufacturingOrderId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_MaterialGroupId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_MaterialId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_MeasurementId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "MeasurementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_SizeId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_UnitId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBalanceLine_WidthId",
            //                table: "ManufacturingOrderBalanceLine",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_ColorId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_ContentId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_ItemTypeId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_ManufacturingOrderId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_MaterialGroupId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_MaterialId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_MOBalanceTypeId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "MOBalanceTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_SizeId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_UnitId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderBomLine_WidthId",
            //                table: "ManufacturingOrderBomLine",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderLine_CustomerId",
            //                table: "ManufacturingOrderLine",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderLine_LabelId",
            //                table: "ManufacturingOrderLine",
            //                column: "LabelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderLine_ManufacturingOrderId",
            //                table: "ManufacturingOrderLine",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderLine_MOLineStatusId",
            //                table: "ManufacturingOrderLine",
            //                column: "MOLineStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderLine_ProductCodeId",
            //                table: "ManufacturingOrderLine",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderLine_ProductionNumberId",
            //                table: "ManufacturingOrderLine",
            //                column: "ProductionNumberId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderLine_SalesOrderLineId",
            //                table: "ManufacturingOrderLine",
            //                column: "SalesOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderMixingColorLine_FabricId",
            //                table: "ManufacturingOrderMixingColorLine",
            //                column: "FabricId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderMixingColorLine_ManufacturingOrderId",
            //                table: "ManufacturingOrderMixingColorLine",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingOrderMixingColorLine_MaterialId",
            //                table: "ManufacturingOrderMixingColorLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPrice_ProductId",
            //                table: "ManufacturingPrice",
            //                column: "ProductId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPrice_ProductionActivityId",
            //                table: "ManufacturingPrice",
            //                column: "ProductionActivityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPrice_StatusId",
            //                table: "ManufacturingPrice",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPriceLine_ConfirmEmpId",
            //                table: "ManufacturingPriceLine",
            //                column: "ConfirmEmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPriceLine_ManufacturingPriceId",
            //                table: "ManufacturingPriceLine",
            //                column: "ManufacturingPriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPriceLine_ManufacturingPriceTypeId",
            //                table: "ManufacturingPriceLine",
            //                column: "ManufacturingPriceTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPriceLine_ProductionActivityLineId",
            //                table: "ManufacturingPriceLine",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingPriceLine_UnitId",
            //                table: "ManufacturingPriceLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingSize_ManufacturingOrderId",
            //                table: "ManufacturingSize",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ManufacturingSize_ManufacturingOrderLineId",
            //                table: "ManufacturingSize",
            //                column: "ManufacturingOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_Code",
            //                table: "Material",
            //                column: "Code",
            //                unique: true,
            //                filter: "[Code] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_ColorId",
            //                table: "Material",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_ContentId",
            //                table: "Material",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_ItemTypeId",
            //                table: "Material",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_MaterialGroupId",
            //                table: "Material",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_SizeId",
            //                table: "Material",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_UnitId",
            //                table: "Material",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Material_WidthId",
            //                table: "Material",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_ColorId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_ContentId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_ItemTypeId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_MaterialGroupId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_MaterialId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_MaterialRequestWareHouseId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "MaterialRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_SampleOrderId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_SizeId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_UnitId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialBookingWareHouseLine_WidthId",
            //                table: "MaterialBookingWareHouseLine",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialDetail_Code",
            //                table: "MaterialDetail",
            //                column: "Code",
            //                unique: true,
            //                filter: "[Code] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialDetail_MaterialId",
            //                table: "MaterialDetail",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialDetail_SupplierId",
            //                table: "MaterialDetail",
            //                column: "SupplierId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_CurrencyId",
            //                table: "MaterialIssueWareHouse",
            //                column: "CurrencyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_EmployeeId",
            //                table: "MaterialIssueWareHouse",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_ExportTypeId",
            //                table: "MaterialIssueWareHouse",
            //                column: "ExportTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_LocationId",
            //                table: "MaterialIssueWareHouse",
            //                column: "LocationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_ManufacturerId",
            //                table: "MaterialIssueWareHouse",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_MaterialRequestWareHouseId",
            //                table: "MaterialIssueWareHouse",
            //                column: "MaterialRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_StatusId",
            //                table: "MaterialIssueWareHouse",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_SupplierId",
            //                table: "MaterialIssueWareHouse",
            //                column: "SupplierId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouse_WarehouseId",
            //                table: "MaterialIssueWareHouse",
            //                column: "WarehouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_ColorId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_ContentId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_ItemTypeId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_MaterialId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_MaterialIssueWareHouseId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "MaterialIssueWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_MaterialReplacementId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "MaterialReplacementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_SampleOrderId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_SizeId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_SupplierId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "SupplierId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_SWLId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "SWLId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_UnitId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialIssueWareHouseLine_WidthId",
            //                table: "MaterialIssueWareHouseLine",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_ColorId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_ContentId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_ItemTypeId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_LocationId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "LocationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_MaterialGroupId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_MaterialId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_SizeId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_SWLId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "SWLId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_UnitId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_WarehouseId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "WarehouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouse_WidthId",
            //                table: "MaterialOnhandWareHouse",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_BOMId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "BOMId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_ColorId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_ContentId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_ItemTypeId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_MaterialRequestWareHouseId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "MaterialRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_SampleOrderId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_SizeId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_SupplierId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "SupplierId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_SWLId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "SWLId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_UnitId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_WareHouseTypeStatusId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "WareHouseTypeStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseLog_WidthId",
            //                table: "MaterialOnhandWareHouseLog",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_ColorId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_ContentId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_ItemTypeId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_LocationId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "LocationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_MaterialGroupId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_MaterialId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_MaterialRequestWareHouseId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "MaterialRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_RequestWareHouseTypeStatusId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "RequestWareHouseTypeStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_SizeId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_SupplierId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "SupplierId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_SWLId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "SWLId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_UnitId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_WarehouseId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "WarehouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOnhandWareHouseRequestLog_WidthId",
            //                table: "MaterialOnhandWareHouseRequestLog",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_BOMId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "BOMId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_ColorId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_ContentId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_ItemTypeId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_MaterialGroupId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_MaterialId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_MaterialIssueWareHouseId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "MaterialIssueWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_SizeId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_SupplierId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "SupplierId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_SWLId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "SWLId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_UnitId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialOutwardWareHouseLog_WidthId",
            //                table: "MaterialOutwardWareHouseLog",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_EmployeeId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_InwardOrderId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "InwardOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_LocationId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "LocationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_ManufacturingOrderId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_MaterialRequestWareHouseId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "MaterialRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_ReceiptWareHouseTypeId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "ReceiptWareHouseTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_StatusId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouse_WarehouseId",
            //                table: "MaterialReceiptWareHouse",
            //                column: "WarehouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_ColorId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_ContentId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_ItemTypeId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_MaterialGroupId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_MaterialId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_MaterialReceiptWareHouseId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "MaterialReceiptWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_SizeId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_SupplierId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "SupplierId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_SWLId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "SWLId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_UnitId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReceiptWareHouseLine_WidthId",
            //                table: "MaterialReceiptWareHouseLine",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_ColorId",
            //                table: "MaterialReplacement",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_ContentId",
            //                table: "MaterialReplacement",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_ItemTypeId",
            //                table: "MaterialReplacement",
            //                column: "ItemTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_MaterialId",
            //                table: "MaterialReplacement",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_ReplacementId",
            //                table: "MaterialReplacement",
            //                column: "ReplacementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_SizeId",
            //                table: "MaterialReplacement",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_UnitId",
            //                table: "MaterialReplacement",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialReplacement_WidthId",
            //                table: "MaterialReplacement",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_ApproveEmployeeId",
            //                table: "MaterialRequestWareHouse",
            //                column: "ApproveEmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_DepartmentId",
            //                table: "MaterialRequestWareHouse",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_EmployeeId",
            //                table: "MaterialRequestWareHouse",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_OrderTypeId",
            //                table: "MaterialRequestWareHouse",
            //                column: "OrderTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_ReasonId",
            //                table: "MaterialRequestWareHouse",
            //                column: "ReasonId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_RequestStatusId",
            //                table: "MaterialRequestWareHouse",
            //                column: "RequestStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_RequestTypeId",
            //                table: "MaterialRequestWareHouse",
            //                column: "RequestTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MaterialRequestWareHouse_WareHouseId",
            //                table: "MaterialRequestWareHouse",
            //                column: "WareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MenuItem_MenuItemId",
            //                table: "MenuItem",
            //                column: "MenuItemId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignment_CreatorId",
            //                table: "MonthlyAssignment",
            //                column: "CreatorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignment_DepartmentId",
            //                table: "MonthlyAssignment",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignment_EmployeeGroupId",
            //                table: "MonthlyAssignment",
            //                column: "EmployeeGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignment_MonthId",
            //                table: "MonthlyAssignment",
            //                column: "MonthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignment_YearId",
            //                table: "MonthlyAssignment",
            //                column: "YearId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignmentLine_EmployeeId",
            //                table: "MonthlyAssignmentLine",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignmentLine_LeaderId",
            //                table: "MonthlyAssignmentLine",
            //                column: "LeaderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAssignmentLine_MonthlyAssignmentId",
            //                table: "MonthlyAssignmentLine",
            //                column: "MonthlyAssignmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAttendance_ApproverId",
            //                table: "MonthlyAttendance",
            //                column: "ApproverId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAttendance_EmpId",
            //                table: "MonthlyAttendance",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAttendance_RecorderId",
            //                table: "MonthlyAttendance",
            //                column: "RecorderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_MonthlyAttendance_SubmitterId",
            //                table: "MonthlyAttendance",
            //                column: "SubmitterId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_NotifyAppSubscribe_NotifyRuleId",
            //                table: "NotifyAppSubscribe",
            //                column: "NotifyRuleId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_NotifyDismiss_NotifyRuleId",
            //                table: "NotifyDismiss",
            //                column: "NotifyRuleId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_NotifyMailSubscribe_NotifyRuleId",
            //                table: "NotifyMailSubscribe",
            //                column: "NotifyRuleId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_NotifyRuleMapping_NotifyRuleId",
            //                table: "NotifyRuleMapping",
            //                column: "NotifyRuleId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_CompanyId",
            //                table: "OnboardRequest",
            //                column: "CompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_DepartmentId",
            //                table: "OnboardRequest",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_DivisionId",
            //                table: "OnboardRequest",
            //                column: "DivisionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_EmployeeId",
            //                table: "OnboardRequest",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_OnboardStatusId",
            //                table: "OnboardRequest",
            //                column: "OnboardStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_PositionId",
            //                table: "OnboardRequest",
            //                column: "PositionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_ReportToId",
            //                table: "OnboardRequest",
            //                column: "ReportToId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_OnboardRequest_TeamId",
            //                table: "OnboardRequest",
            //                column: "TeamId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_BUId",
            //                table: "Position",
            //                column: "BUId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_CompanyId",
            //                table: "Position",
            //                column: "CompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_DepartmentId",
            //                table: "Position",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_DivisionId",
            //                table: "Position",
            //                column: "DivisionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_PosLevelId",
            //                table: "Position",
            //                column: "PosLevelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_ReportToPosId",
            //                table: "Position",
            //                column: "ReportToPosId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_TeamId",
            //                table: "Position",
            //                column: "TeamId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Position_WorkPlaceId",
            //                table: "Position",
            //                column: "WorkPlaceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_PricePolicy_CustomerId",
            //                table: "PricePolicy",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_PriceStructureLine_CostElementId",
            //                table: "PriceStructureLine",
            //                column: "CostElementId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_PriceStructureLine_PriceStructureId",
            //                table: "PriceStructureLine",
            //                column: "PriceStructureId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_PriceStructureLine_ProductGroupId",
            //                table: "PriceStructureLine",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_PriceStructureProfitByProduct_PriceStructureId",
            //                table: "PriceStructureProfitByProduct",
            //                column: "PriceStructureId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_PriceStructureProfitByProduct_ProductGroupId",
            //                table: "PriceStructureProfitByProduct",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCode_EmployeeId",
            //                table: "ProductCode",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCode_IdeaId",
            //                table: "ProductCode",
            //                column: "IdeaId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCode_ProductGroupId",
            //                table: "ProductCode",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCode_ProductLineId",
            //                table: "ProductCode",
            //                column: "ProductLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCode_ProductTypeId",
            //                table: "ProductCode",
            //                column: "ProductTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCode_SizeScaleId",
            //                table: "ProductCode",
            //                column: "SizeScaleId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCode_UnitId",
            //                table: "ProductCode",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeDevelopingHistory_ManufacturerId",
            //                table: "ProductCodeDevelopingHistory",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeDevelopingHistory_ProductCodeId",
            //                table: "ProductCodeDevelopingHistory",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeDevelopingHistory_ProductTypeId",
            //                table: "ProductCodeDevelopingHistory",
            //                column: "ProductTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeDevelopingHistory_RequestSideId",
            //                table: "ProductCodeDevelopingHistory",
            //                column: "RequestSideId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeDevelopingHistory_SampleOrderId",
            //                table: "ProductCodeDevelopingHistory",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeDevelopingHistory_StatusId",
            //                table: "ProductCodeDevelopingHistory",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeManufacturingHistory_ProductCodeId",
            //                table: "ProductCodeManufacturingHistory",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeOrdersHistory_CustomerId",
            //                table: "ProductCodeOrdersHistory",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeOrdersHistory_ProductCodeId",
            //                table: "ProductCodeOrdersHistory",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeOrdersHistory_SalesOrderId",
            //                table: "ProductCodeOrdersHistory",
            //                column: "SalesOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductCodeOrdersHistory_StatusId",
            //                table: "ProductCodeOrdersHistory",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_CurrencyId",
            //                table: "ProductExportWareHouse",
            //                column: "CurrencyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_CustomerId",
            //                table: "ProductExportWareHouse",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_DepartmentId",
            //                table: "ProductExportWareHouse",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_ExportEmpId",
            //                table: "ProductExportWareHouse",
            //                column: "ExportEmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_ExportStatusId",
            //                table: "ProductExportWareHouse",
            //                column: "ExportStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_MaterialWHExportTypeEnumId",
            //                table: "ProductExportWareHouse",
            //                column: "MaterialWHExportTypeEnumId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_OrderTypesId",
            //                table: "ProductExportWareHouse",
            //                column: "OrderTypesId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouse_WarehouseId",
            //                table: "ProductExportWareHouse",
            //                column: "WarehouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_CustomerId",
            //                table: "ProductExportWareHouseLine",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ExportStatusId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ExportStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ExportTypeId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ExportTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_LocationId",
            //                table: "ProductExportWareHouseLine",
            //                column: "LocationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ManufacturingOrderLineId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ManufacturingOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ProductCodeId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ProductExportWareHouseId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ProductExportWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ProductGroupId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ProductInventoryWareHouseId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ProductInventoryWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ProductionActivityLineId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_ProductTypeId",
            //                table: "ProductExportWareHouseLine",
            //                column: "ProductTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_SampleOrderId",
            //                table: "ProductExportWareHouseLine",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductExportWareHouseLine_UnitId",
            //                table: "ProductExportWareHouseLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouse_ManufacturingOrderId",
            //                table: "ProductInventoryWareHouse",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouse_ProductCodeId",
            //                table: "ProductInventoryWareHouse",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouse_ProductionActivityLineId",
            //                table: "ProductInventoryWareHouse",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouse_ProductRequestWareHouseLineId",
            //                table: "ProductInventoryWareHouse",
            //                column: "ProductRequestWareHouseLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouse_SampleOrderId",
            //                table: "ProductInventoryWareHouse",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouse_WarehouseId",
            //                table: "ProductInventoryWareHouse",
            //                column: "WarehouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_CustomerId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_LocationId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "LocationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_ProductCodeId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_ProductInventoryWareHouseId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "ProductInventoryWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_ProductionActivityLineId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_ProductTypeId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "ProductTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_SalesOrderLineId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "SalesOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_SampleOrderId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_UnitId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductInventoryWareHouseLine_WareHouseTypeStatusId",
            //                table: "ProductInventoryWareHouseLine",
            //                column: "WareHouseTypeStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivity_ManufacturingOrderId",
            //                table: "ProductionActivity",
            //                column: "ManufacturingOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivity_MaterialStatusId",
            //                table: "ProductionActivity",
            //                column: "MaterialStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivity_ProductCodeId",
            //                table: "ProductionActivity",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivity_ProductGroupId",
            //                table: "ProductionActivity",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivity_ProductionStatusId",
            //                table: "ProductionActivity",
            //                column: "ProductionStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_ColorId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_ContentId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_ManufacturingPriceId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "ManufacturingPriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_MaterialGroupId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_MaterialId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_MaterialTypeId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "MaterialTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_ProductionActivityBalanceLineId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "ProductionActivityBalanceLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_ProductionActivityId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "ProductionActivityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_ProductionActivityLineId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityAccessoriesSupply_UnitId",
            //                table: "ProductionActivityAccessoriesSupply",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityBalanceLine_ColorId",
            //                table: "ProductionActivityBalanceLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityBalanceLine_ContentId",
            //                table: "ProductionActivityBalanceLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityBalanceLine_MaterialGroupId",
            //                table: "ProductionActivityBalanceLine",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityBalanceLine_MaterialId",
            //                table: "ProductionActivityBalanceLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityBalanceLine_MaterialTypeId",
            //                table: "ProductionActivityBalanceLine",
            //                column: "MaterialTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityBalanceLine_ProductionActivityId",
            //                table: "ProductionActivityBalanceLine",
            //                column: "ProductionActivityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityBalanceLine_UnitId",
            //                table: "ProductionActivityBalanceLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityDetailLine_ManufacturingTypeId",
            //                table: "ProductionActivityDetailLine",
            //                column: "ManufacturingTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityDetailLine_MaterialTypeId",
            //                table: "ProductionActivityDetailLine",
            //                column: "MaterialTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityDetailLine_ProductionActivityAccessoriesSupplyId",
            //                table: "ProductionActivityDetailLine",
            //                column: "ProductionActivityAccessoriesSupplyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityDetailLine_ProductionActivityId",
            //                table: "ProductionActivityDetailLine",
            //                column: "ProductionActivityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityDetailLine_ProductionActivityLineId",
            //                table: "ProductionActivityDetailLine",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityDetailLine_UnitId",
            //                table: "ProductionActivityDetailLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_CustomerId",
            //                table: "ProductionActivityLine",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_LabelId",
            //                table: "ProductionActivityLine",
            //                column: "LabelId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_ManufacturerId",
            //                table: "ProductionActivityLine",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_ManufacturerTypeId",
            //                table: "ProductionActivityLine",
            //                column: "ManufacturerTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_ManufacturingOrderLineId",
            //                table: "ProductionActivityLine",
            //                column: "ManufacturingOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_ManufacturingPriceId",
            //                table: "ProductionActivityLine",
            //                column: "ManufacturingPriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_PAStatusId",
            //                table: "ProductionActivityLine",
            //                column: "PAStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_ProductionActivityId",
            //                table: "ProductionActivityLine",
            //                column: "ProductionActivityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_QCId",
            //                table: "ProductionActivityLine",
            //                column: "QCId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_SalesOrderLineId",
            //                table: "ProductionActivityLine",
            //                column: "SalesOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLine_StatusId",
            //                table: "ProductionActivityLine",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLineHistory_ManufacturerId",
            //                table: "ProductionActivityLineHistory",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivityLineHistory_ProductionActivityLineId",
            //                table: "ProductionActivityLineHistory",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivitySizeColor_ProductionActivityId",
            //                table: "ProductionActivitySizeColor",
            //                column: "ProductionActivityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductionActivitySizeColor_ProductionActivityLineId",
            //                table: "ProductionActivitySizeColor",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_BorrowerId",
            //                table: "ProductPlan",
            //                column: "BorrowerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_ColorId",
            //                table: "ProductPlan",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_CustomerId",
            //                table: "ProductPlan",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_FabricId",
            //                table: "ProductPlan",
            //                column: "FabricId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_FinishedProductStatusId",
            //                table: "ProductPlan",
            //                column: "FinishedProductStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_FixReasonId",
            //                table: "ProductPlan",
            //                column: "FixReasonId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_ManuBorrowerId",
            //                table: "ProductPlan",
            //                column: "ManuBorrowerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_ManufacturerId",
            //                table: "ProductPlan",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_PrintingEmbroideryStatusId",
            //                table: "ProductPlan",
            //                column: "PrintingEmbroideryStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_ProductCodeId",
            //                table: "ProductPlan",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_ProductGroupId",
            //                table: "ProductPlan",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_ProductTypeId",
            //                table: "ProductPlan",
            //                column: "ProductTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_ReasonId",
            //                table: "ProductPlan",
            //                column: "ReasonId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_RequiredFromId",
            //                table: "ProductPlan",
            //                column: "RequiredFromId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_RQBOMStatusId",
            //                table: "ProductPlan",
            //                column: "RQBOMStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_SampleOrderId",
            //                table: "ProductPlan",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_SampleOrderReferId",
            //                table: "ProductPlan",
            //                column: "SampleOrderReferId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlan_SampleOrderTypeId",
            //                table: "ProductPlan",
            //                column: "SampleOrderTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLog_ProductPlanId",
            //                table: "ProductPlanLog",
            //                column: "ProductPlanId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLog_ProductPlanNewStatusId",
            //                table: "ProductPlanLog",
            //                column: "ProductPlanNewStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLog_ProductPlanOldStatusId",
            //                table: "ProductPlanLog",
            //                column: "ProductPlanOldStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLog_SampleOrderTypeId",
            //                table: "ProductPlanLog",
            //                column: "SampleOrderTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLogCoefficient_ManufacturerId",
            //                table: "ProductPlanLogCoefficient",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLogCoefficient_ManufacturerTypeId",
            //                table: "ProductPlanLogCoefficient",
            //                column: "ManufacturerTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLogCoefficient_ManufacturingDetailId",
            //                table: "ProductPlanLogCoefficient",
            //                column: "ManufacturingDetailId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLogCoefficient_ProductPlanId",
            //                table: "ProductPlanLogCoefficient",
            //                column: "ProductPlanId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLogCoefficient_ProductPlanLogId",
            //                table: "ProductPlanLogCoefficient",
            //                column: "ProductPlanLogId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanLogCoefficient_SampleOrderTypeId",
            //                table: "ProductPlanLogCoefficient",
            //                column: "SampleOrderTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanPrintingEmbroidery_EmbroideryStatusId",
            //                table: "ProductPlanPrintingEmbroidery",
            //                column: "EmbroideryStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanPrintingEmbroidery_PrintingStatusId",
            //                table: "ProductPlanPrintingEmbroidery",
            //                column: "PrintingStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanPrintingEmbroidery_ProductPlanId",
            //                table: "ProductPlanPrintingEmbroidery",
            //                column: "ProductPlanId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductPlanPrintingEmbroidery_SampleOrderId",
            //                table: "ProductPlanPrintingEmbroidery",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_CurrencyId",
            //                table: "ProductRequestWareHouse",
            //                column: "CurrencyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_CustomerId",
            //                table: "ProductRequestWareHouse",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_DepartmentId",
            //                table: "ProductRequestWareHouse",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_EmpId",
            //                table: "ProductRequestWareHouse",
            //                column: "EmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_ImportStatusId",
            //                table: "ProductRequestWareHouse",
            //                column: "ImportStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_ImportTypeId",
            //                table: "ProductRequestWareHouse",
            //                column: "ImportTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_ManufacturerId",
            //                table: "ProductRequestWareHouse",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_MaterialWHRequestTypeEnumId",
            //                table: "ProductRequestWareHouse",
            //                column: "MaterialWHRequestTypeEnumId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_OrderTypesId",
            //                table: "ProductRequestWareHouse",
            //                column: "OrderTypesId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_RequestEmpId",
            //                table: "ProductRequestWareHouse",
            //                column: "RequestEmpId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_RequestStatusId",
            //                table: "ProductRequestWareHouse",
            //                column: "RequestStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouse_WarehouseId",
            //                table: "ProductRequestWareHouse",
            //                column: "WarehouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_CustomerId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_LocationId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "LocationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_ManufacturingOrderLineId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "ManufacturingOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_ProductCodeId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_ProductGroupId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "ProductGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_ProductionActivityLineId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "ProductionActivityLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_ProductRequestWareHouseId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "ProductRequestWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_ProductTypeId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "ProductTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_RequestStatusId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "RequestStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_RequestTypeId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "RequestTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_SampleOrderId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ProductRequestWareHouseLine_UnitId",
            //                table: "ProductRequestWareHouseLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_QuickOrder_ProductCodeGroupId",
            //                table: "QuickOrder",
            //                column: "ProductCodeGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_QuickOrder_ProductCodeId",
            //                table: "QuickOrder",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_QuickOrder_ProductCodeLineId",
            //                table: "QuickOrder",
            //                column: "ProductCodeLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_QuickOrderLine_CustomerId",
            //                table: "QuickOrderLine",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_QuickOrderLine_FabricId",
            //                table: "QuickOrderLine",
            //                column: "FabricId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_QuickOrderLine_FabricIngredientId",
            //                table: "QuickOrderLine",
            //                column: "FabricIngredientId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_QuickOrderLine_QuickOrderId",
            //                table: "QuickOrderLine",
            //                column: "QuickOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_CompanyId",
            //                table: "ResignRequest",
            //                column: "CompanyId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_DepartmentId",
            //                table: "ResignRequest",
            //                column: "DepartmentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_DivisionId",
            //                table: "ResignRequest",
            //                column: "DivisionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_EmployeeId",
            //                table: "ResignRequest",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_PositionId",
            //                table: "ResignRequest",
            //                column: "PositionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_ReportToId",
            //                table: "ResignRequest",
            //                column: "ReportToId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_ResignStatusId",
            //                table: "ResignRequest",
            //                column: "ResignStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_ResignRequest_TeamId",
            //                table: "ResignRequest",
            //                column: "TeamId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SaleQuotation_ApprovedStatusId",
            //                table: "SaleQuotation",
            //                column: "ApprovedStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SaleQuotation_StatusId",
            //                table: "SaleQuotation",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SaleQuotationLine_SaleQuotationId",
            //                table: "SaleQuotationLine",
            //                column: "SaleQuotationId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SaleQuotationLine_SamplePriceId",
            //                table: "SaleQuotationLine",
            //                column: "SamplePriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrder_CustomerId",
            //                table: "SalesOrder",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrder_StatusId",
            //                table: "SalesOrder",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrderColorRates_ColorId",
            //                table: "SalesOrderColorRates",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrderColorRates_SalesOrderId",
            //                table: "SalesOrderColorRates",
            //                column: "SalesOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrderColorRates_SalesOrderLineId",
            //                table: "SalesOrderColorRates",
            //                column: "SalesOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrderLine_SalesOrderId",
            //                table: "SalesOrderLine",
            //                column: "SalesOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrderSize_SalesOrderId",
            //                table: "SalesOrderSize",
            //                column: "SalesOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SalesOrderSize_SalesOrderLineId",
            //                table: "SalesOrderSize",
            //                column: "SalesOrderLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleCost_BOMId",
            //                table: "SampleCost",
            //                column: "BOMId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleCost_ManufacturerId",
            //                table: "SampleCost",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleCost_MaterialId",
            //                table: "SampleCost",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleCost_ProductPlanId",
            //                table: "SampleCost",
            //                column: "ProductPlanId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleCost_ProductPlanLogCoefficientId",
            //                table: "SampleCost",
            //                column: "ProductPlanLogCoefficientId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleCost_SampleOrderId",
            //                table: "SampleCost",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleCost_SamplePriceId",
            //                table: "SampleCost",
            //                column: "SamplePriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_ColorId",
            //                table: "SampleMaterialLine",
            //                column: "ColorId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_ContentId",
            //                table: "SampleMaterialLine",
            //                column: "ContentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_MaterialGroupId",
            //                table: "SampleMaterialLine",
            //                column: "MaterialGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_MaterialId",
            //                table: "SampleMaterialLine",
            //                column: "MaterialId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_MaterialIssueWareHouseId",
            //                table: "SampleMaterialLine",
            //                column: "MaterialIssueWareHouseId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_MaterialTypeId",
            //                table: "SampleMaterialLine",
            //                column: "MaterialTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_SampleOrderId",
            //                table: "SampleMaterialLine",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_SizeId",
            //                table: "SampleMaterialLine",
            //                column: "SizeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_UnitId",
            //                table: "SampleMaterialLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialLine_WidthId",
            //                table: "SampleMaterialLine",
            //                column: "WidthId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialPriceLine_ProductPlanLogCoefficientId",
            //                table: "SampleMaterialPriceLine",
            //                column: "ProductPlanLogCoefficientId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialPriceLine_SampleMaterialLineId",
            //                table: "SampleMaterialPriceLine",
            //                column: "SampleMaterialLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialPriceLine_SamplePriceId",
            //                table: "SampleMaterialPriceLine",
            //                column: "SamplePriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleMaterialPriceLine_UnitId",
            //                table: "SampleMaterialPriceLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_CustomerId",
            //                table: "SampleOrder",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_EmployeeId",
            //                table: "SampleOrder",
            //                column: "EmployeeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_EmPrId",
            //                table: "SampleOrder",
            //                column: "EmPrId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_FabricId",
            //                table: "SampleOrder",
            //                column: "FabricId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_FixReasonId",
            //                table: "SampleOrder",
            //                column: "FixReasonId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_ManufacturerId",
            //                table: "SampleOrder",
            //                column: "ManufacturerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_ProductCodeId",
            //                table: "SampleOrder",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_ProductTypeId",
            //                table: "SampleOrder",
            //                column: "ProductTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_RequiredFromId",
            //                table: "SampleOrder",
            //                column: "RequiredFromId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_SampleOrderReferId",
            //                table: "SampleOrder",
            //                column: "SampleOrderReferId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SampleOrder_SampleTailorTypeId",
            //                table: "SampleOrder",
            //                column: "SampleTailorTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePrice_FabricId",
            //                table: "SamplePrice",
            //                column: "FabricId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePrice_PriceStructureId",
            //                table: "SamplePrice",
            //                column: "PriceStructureId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePrice_ProductCodeId",
            //                table: "SamplePrice",
            //                column: "ProductCodeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePrice_RequiredFromId",
            //                table: "SamplePrice",
            //                column: "RequiredFromId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePrice_SampleOrderCustomerId",
            //                table: "SamplePrice",
            //                column: "SampleOrderCustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePrice_SampleOrderId",
            //                table: "SamplePrice",
            //                column: "SampleOrderId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePrice_StatusId",
            //                table: "SamplePrice",
            //                column: "StatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePriceLine_ManufacturingPriceId",
            //                table: "SamplePriceLine",
            //                column: "ManufacturingPriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePriceLine_SampleMaterialLineId",
            //                table: "SamplePriceLine",
            //                column: "SampleMaterialLineId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePriceLine_SamplePriceId",
            //                table: "SamplePriceLine",
            //                column: "SamplePriceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SamplePriceLine_UnitId",
            //                table: "SamplePriceLine",
            //                column: "UnitId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Supplier_Name",
            //                table: "Supplier",
            //                column: "Name",
            //                unique: true,
            //                filter: "[Name] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Supplier_PaymentMenthodId",
            //                table: "Supplier",
            //                column: "PaymentMenthodId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Supplier_SupplierGroupId",
            //                table: "Supplier",
            //                column: "SupplierGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Supplier_SupplierTypeId",
            //                table: "Supplier",
            //                column: "SupplierTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SysEntity_EQDTableId",
            //                table: "SysEntity",
            //                column: "EQDTableId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SysEnumElement_ParentId",
            //                table: "SysEnumElement",
            //                column: "ParentId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SysEnumElement_SysEnumId",
            //                table: "SysEnumElement",
            //                column: "SysEnumId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SysLanguageCaption_SysLanguageId",
            //                table: "SysLanguageCaption",
            //                column: "SysLanguageId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SysLanguageCaptionUsing_SysObjectId",
            //                table: "SysLanguageCaptionUsing",
            //                column: "SysObjectId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SysObject_CloneOptionId",
            //                table: "SysObject",
            //                column: "CloneOptionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_SysObject_EntityId",
            //                table: "SysObject",
            //                column: "EntityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Tasks_AssigneeId",
            //                table: "Tasks",
            //                column: "AssigneeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Tasks_AssignerId",
            //                table: "Tasks",
            //                column: "AssignerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_UserSession_UserId",
            //                table: "UserSession",
            //                column: "UserId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Warehouse_CustomerId",
            //                table: "Warehouse",
            //                column: "CustomerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Warehouse_Name",
            //                table: "Warehouse",
            //                column: "Name",
            //                unique: true,
            //                filter: "[Name] IS NOT NULL");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_Warehouse_WarehouseTypeId",
            //                table: "Warehouse",
            //                column: "WarehouseTypeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WF_SysEntityId",
            //                table: "WF",
            //                column: "SysEntityId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFActionRule_WFStatusActionId",
            //                table: "WFActionRule",
            //                column: "WFStatusActionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFFinanceRequestSetting_SubmitterId",
            //                table: "WFFinanceRequestSetting",
            //                column: "SubmitterId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFFinanceRequestSetting_ViewerId",
            //                table: "WFFinanceRequestSetting",
            //                column: "ViewerId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstance_CurrentStatusId",
            //                table: "WFInstance",
            //                column: "CurrentStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstance_WFId",
            //                table: "WFInstance",
            //                column: "WFId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceHist_FromEmplId",
            //                table: "WFInstanceHist",
            //                column: "FromEmplId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceHist_FromStatusId",
            //                table: "WFInstanceHist",
            //                column: "FromStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceHist_ToEmplId",
            //                table: "WFInstanceHist",
            //                column: "ToEmplId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceHist_ToStatusId",
            //                table: "WFInstanceHist",
            //                column: "ToStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceHist_WFActionId",
            //                table: "WFInstanceHist",
            //                column: "WFActionId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceHist_WFInstanceId",
            //                table: "WFInstanceHist",
            //                column: "WFInstanceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceStatusActorAssigment_ApproverEmplId",
            //                table: "WFInstanceStatusActorAssigment",
            //                column: "ApproverEmplId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceStatusActorAssigment_SubmitterEmplId",
            //                table: "WFInstanceStatusActorAssigment",
            //                column: "SubmitterEmplId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceStatusActorAssigment_SupporterEmplId",
            //                table: "WFInstanceStatusActorAssigment",
            //                column: "SupporterEmplId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceStatusActorAssigment_TeamId",
            //                table: "WFInstanceStatusActorAssigment",
            //                column: "TeamId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceStatusActorAssigment_WFInstanceId",
            //                table: "WFInstanceStatusActorAssigment",
            //                column: "WFInstanceId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFInstanceStatusActorAssigment_WFStatusId",
            //                table: "WFInstanceStatusActorAssigment",
            //                column: "WFStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatus_EmployeeGroupId",
            //                table: "WFStatus",
            //                column: "EmployeeGroupId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatus_WFId",
            //                table: "WFStatus",
            //                column: "WFId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusAction_NotifyAppSubscribeId",
            //                table: "WFStatusAction",
            //                column: "NotifyAppSubscribeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusAction_NotifyMailSubscribeId",
            //                table: "WFStatusAction",
            //                column: "NotifyMailSubscribeId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusAction_ToStatusId",
            //                table: "WFStatusAction",
            //                column: "ToStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusAction_WFStatusId",
            //                table: "WFStatusAction",
            //                column: "WFStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusActorPermission_WFStatusId",
            //                table: "WFStatusActorPermission",
            //                column: "WFStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusApproverDefault_ApproverId",
            //                table: "WFStatusApproverDefault",
            //                column: "ApproverId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusApproverDefault_SubmitterId",
            //                table: "WFStatusApproverDefault",
            //                column: "SubmitterId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WFStatusApproverDefault_WFStatusId",
            //                table: "WFStatusApproverDefault",
            //                column: "WFStatusId");

            //            migrationBuilder.CreateIndex(
            //                name: "IX_WorkingDay_WorkTypeId",
            //                table: "WorkingDay",
            //                column: "WorkTypeId");

            //            migrationBuilder.AddForeignKey(
            //                name: "FK_AspNetUsers_Employee_EmployeeId",
            //                table: "AspNetUsers",
            //                column: "EmployeeId",
            //                principalTable: "Employee",
            //                principalColumn: "Id");

            //            migrationBuilder.AddForeignKey(
            //                name: "FK_Attachment_Employee_EmployeeId",
            //                table: "Attachment",
            //                column: "EmployeeId",
            //                principalTable: "Employee",
            //                principalColumn: "Id");

            //            migrationBuilder.AddForeignKey(
            //                name: "FK_BOM_SampleOrder_SampleOrderId",
            //                table: "BOM",
            //                column: "SampleOrderId",
            //                principalTable: "SampleOrder",
            //                principalColumn: "Id");

            //            migrationBuilder.AddForeignKey(
            //                name: "FK_BusinessUnit_Employee_HeadEmpId",
            //                table: "BusinessUnit",
            //                column: "HeadEmpId",
            //                principalTable: "Employee",
            //                principalColumn: "Id");
        }
    }
}
