using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class quotation_details_in : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaimSettlementBasisText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ClauseName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "CoInsuranceOutValue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "CoInsuranceShareValue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "CoInsurerName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "Deductible",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "DeductibleFire",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "DutyOfDisclosureText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "EvaluationDetailPictureRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "EvaluationDetailText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "EvaluationTotalScore",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "JurisdictionLawText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LimitOfLiability",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationAttachmentRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationCountActual",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationCountActualAlt",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationCountAnnual",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationCountDeclared",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationCountLegacy",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationMapRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationSituation",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationSubAttachmentRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LocationSummary",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccLossAmount",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccNoClaimText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccPremium",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccRatio",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryLossAmount",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryLossRatio",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryNoClaimText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LossHistoryPremium",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "MktAuthorityFormRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "MktAuthorityText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "NetRetentionValue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "QuotationLocationCount",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ReferralReasonsText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ReferralRequiredFlag",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ReferralType",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "RetentionValue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "RiArrangementAttachmentRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "RiArrangementText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "RiskGrade",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "RiskGradeTableJson",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "RiskGradeType",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "RiskGradingText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "SpecialAppliedSpec",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TermsConditionsText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TermsMultiLangJson",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TreatySurplusValue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAcceptedDate",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAcceptedFlag",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAccumulatedMetric",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAnnualMetric",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAssessorName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAttachmentRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAuthorityConditionsText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAuthorityFormRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwAuthorityText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwBusinessStartedYearOrDate",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwCommentText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwCommentsAttachmentRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwEilrAtExpiryMetric",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwEvaluationDetailPictureRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwEvaluationDetailText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwEvaluationTotalScore",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwFormFlag",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwJapaneseNonJapaneseCode",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwLeaderName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwLeaderUsername",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwLineOfBusinessText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwLossRatioAccumulatedMetric",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwMktCommentText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwOccupationText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwPolicyHolderText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwPortfolioName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwPricingPictureRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwPricingText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwReferralReasonText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwReferralType",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwRelatedFilesRef",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwSourceName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwSumInsLimitText",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "UwSumInsPictureRef",
                table: "Quotation");

            migrationBuilder.CreateTable(
                name: "QuotationDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationCountDeclared = table.Column<int>(type: "int", nullable: true),
                    QuotationLocationCount = table.Column<int>(type: "int", nullable: true),
                    LocationCountLegacy = table.Column<int>(type: "int", nullable: true),
                    LocationCountAnnual = table.Column<int>(type: "int", nullable: true),
                    LocationCountActual = table.Column<int>(type: "int", nullable: true),
                    LocationCountActualAlt = table.Column<int>(type: "int", nullable: true),
                    LocationSummary = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LocationSituation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LocationMapRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LocationAttachmentRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LocationSubAttachmentRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TermsConditionsText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ClaimSettlementBasisText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    JurisdictionLawText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DutyOfDisclosureText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TermsMultiLangJson = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ClauseName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SpecialAppliedSpec = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Deductible = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeductibleFire = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LimitOfLiability = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ReferralRequiredFlag = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ReferralReasonsText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ReferralType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiskGrade = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiskGradingText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiskGradeTableJson = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiskGradeType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwCommentText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    UwCommentsAttachmentRef = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    UwAttachmentRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAcceptedFlag = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAcceptedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UwAssessorName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwPortfolioName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwJapaneseNonJapaneseCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwSourceName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwBusinessStartedYearOrDate = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwOccupationText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwPolicyHolderText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwLineOfBusinessText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwReferralType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwReferralReasonText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwRelatedFilesRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwMktCommentText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    RiArrangementText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiArrangementAttachmentRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RetentionValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NetRetentionValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TreatySurplusValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CoInsuranceShareValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CoInsuranceOutValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CoInsurerName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryNoClaimText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryAccNoClaimText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryLossAmount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    LossHistoryAccLossAmount = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    LossHistoryLossRatio = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    LossHistoryAccRatio = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    LossHistoryPremium = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    LossHistoryAccPremium = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    LossHistoryAccText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    EvaluationTotalScore = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    EvaluationDetailText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    EvaluationDetailPictureRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwEvaluationTotalScore = table.Column<decimal>(type: "decimal(28,9)", nullable: true),
                    UwEvaluationDetailText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwEvaluationDetailPictureRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwPricingText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwPricingPictureRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwSumInsLimitText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwSumInsPictureRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAnnualMetric = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAccumulatedMetric = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwEilrAtExpiryMetric = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwLossRatioAccumulatedMetric = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwLeaderUsername = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwLeaderName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwFormFlag = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAuthorityText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAuthorityConditionsText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAuthorityFormRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    MktAuthorityText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    MktAuthorityFormRef = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
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
                    table.PrimaryKey("PK_QuotationDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuotationSubDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_QuotationSubDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuotationDetails");

            migrationBuilder.DropTable(
                name: "QuotationSubDetails");

            migrationBuilder.AddColumn<string>(
                name: "ClaimSettlementBasisText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClauseName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsuranceOutValue",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsuranceShareValue",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsurerName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deductible",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeductibleFire",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DutyOfDisclosureText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationDetailPictureRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationDetailText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EvaluationTotalScore",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JurisdictionLawText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LimitOfLiability",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationAttachmentRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountActual",
                table: "Quotation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountActualAlt",
                table: "Quotation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountAnnual",
                table: "Quotation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountDeclared",
                table: "Quotation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountLegacy",
                table: "Quotation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationMapRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationSituation",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationSubAttachmentRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationSummary",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryAccLossAmount",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistoryAccNoClaimText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryAccPremium",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryAccRatio",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistoryAccText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryLossAmount",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryLossRatio",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistoryNoClaimText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryPremium",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MktAuthorityFormRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MktAuthorityText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetRetentionValue",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuotationLocationCount",
                table: "Quotation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferralReasonsText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferralRequiredFlag",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferralType",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RetentionValue",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiArrangementAttachmentRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiArrangementText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskGrade",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskGradeTableJson",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskGradeType",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskGradingText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialAppliedSpec",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TermsConditionsText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TermsMultiLangJson",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatySurplusValue",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UwAcceptedDate",
                table: "Quotation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAcceptedFlag",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAccumulatedMetric",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAnnualMetric",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAssessorName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAttachmentRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAuthorityConditionsText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAuthorityFormRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAuthorityText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwBusinessStartedYearOrDate",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwCommentText",
                table: "Quotation",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwCommentsAttachmentRef",
                table: "Quotation",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwEilrAtExpiryMetric",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwEvaluationDetailPictureRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwEvaluationDetailText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UwEvaluationTotalScore",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwFormFlag",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwJapaneseNonJapaneseCode",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLeaderName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLeaderUsername",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLineOfBusinessText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLossRatioAccumulatedMetric",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwMktCommentText",
                table: "Quotation",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwOccupationText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPolicyHolderText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPortfolioName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPricingPictureRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPricingText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwReferralReasonText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwReferralType",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwRelatedFilesRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwSourceName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwSumInsLimitText",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwSumInsPictureRef",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }
    }
}
