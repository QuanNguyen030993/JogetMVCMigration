using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class policy_issuance_break_detail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChassisEngineNumber",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "CoInsuranceNote",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "CoInsuranceOutward",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "CoInsurerName",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "DeclarationText",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "FactoryOperationYears",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "FinalPremium",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "HoldCoverType",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "IsBodApproved",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "IsGlobalCover",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "IsKycChecked",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "MachineryList",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "NewReplacementValue",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PolicyLocation",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PremiumBreakdown",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PropertyTypeList",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ReinsuranceType",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "RiClosings",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "RiScheme",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "SumInsuredBreakdown",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "URF",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "BusinessOccupation",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "VatFlagOrValue",
                table: "Quotation",
                newName: "InsRegisteredAddress");

            migrationBuilder.RenameColumn(
                name: "CurrencyCode",
                table: "Quotation",
                newName: "BusinessOccupation");

            migrationBuilder.AddColumn<long>(
                name: "ClauseId",
                table: "QuotationSubDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeductibleId",
                table: "QuotationSubDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InstallmentId",
                table: "QuotationSubDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ActualDays",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BIQtNum",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CoverageId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IncBIQuoId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IncIARQuoId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsPeriodId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodInsuranceEndDate",
                table: "QuotationDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodInsuranceStartDate",
                table: "QuotationDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "QuotationId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TmivShare",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VAT",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "VATValue",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalDue",
                table: "Quotation",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,9)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PremiumTotalBeforeVat",
                table: "Quotation",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,9)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PremiumTotal",
                table: "Quotation",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,9)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CurrencyId",
                table: "Quotation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffCode",
                table: "Client",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PolicyIssuanceDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyIssuanceId = table.Column<long>(type: "bigint", nullable: true),
                    RiScheme = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    RiClosings = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    FinalPremium = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    PremiumBreakdown = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsKycChecked = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    DeclarationText = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsBodApproved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    URFAttachment = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    MachineryList = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    FactoryOperationYears = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    ChassisEngineNumber = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    NewReplacementValue = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    SumInsuredBreakdown = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsGlobalCover = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    EmailInformRi = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    ResultAttachment = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    ConfirmedQuotationFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    ProposalForm = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Ichigenka = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    PolicyNoCL = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    TheInsured = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Occupation = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    OccupationFCICode = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    RiskGrading = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    POI = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    TSI = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Premium = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Deductible = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    TnCs = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    OccupationCode = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    PremiumRate = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyIssuanceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyIssuanceSubDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyIssuanceId = table.Column<long>(type: "bigint", nullable: true),
                    TranNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Renew = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Endorsment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyIssuanceSubDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyIssuanceDetails");

            migrationBuilder.DropTable(
                name: "PolicyIssuanceSubDetails");

            migrationBuilder.DropColumn(
                name: "ClauseId",
                table: "QuotationSubDetails");

            migrationBuilder.DropColumn(
                name: "DeductibleId",
                table: "QuotationSubDetails");

            migrationBuilder.DropColumn(
                name: "InstallmentId",
                table: "QuotationSubDetails");

            migrationBuilder.DropColumn(
                name: "ActualDays",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "BIQtNum",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "CoverageId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "IncBIQuoId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "IncIARQuoId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "InsPeriodId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PeriodInsuranceEndDate",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PeriodInsuranceStartDate",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "QuotationId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "TmivShare",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "VAT",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "VATValue",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Quotation");

            migrationBuilder.RenameColumn(
                name: "InsRegisteredAddress",
                table: "Quotation",
                newName: "VatFlagOrValue");

            migrationBuilder.RenameColumn(
                name: "BusinessOccupation",
                table: "Quotation",
                newName: "CurrencyCode");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDue",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PremiumTotalBeforeVat",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PremiumTotal",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChassisEngineNumber",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsuranceNote",
                table: "PolicyIssuance",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsuranceOutward",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsurerName",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeclarationText",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FactoryOperationYears",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FinalPremium",
                table: "PolicyIssuance",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoldCoverType",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsBodApproved",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsGlobalCover",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsKycChecked",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineryList",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NewReplacementValue",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyLocation",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PremiumBreakdown",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyTypeList",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReinsuranceType",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiClosings",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiScheme",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SumInsuredBreakdown",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URF",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffCode",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessOccupation",
                table: "Client",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }
    }
}
