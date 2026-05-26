using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class adjust_quo_pi_attrib : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaimSettlementBasisText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ClauseName",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "CoInsuranceOutValue",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "CoInsuranceShareValue",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "CoInsurerName",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "Deductible",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "DeductibleFire",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "DutyOfDisclosureText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "EvaluationDetailPictureRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "EvaluationDetailText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "EvaluationTotalScore",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "JurisdictionLawText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LimitOfLiability",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationAttachmentRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationCountActual",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationCountActualAlt",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationCountAnnual",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationCountDeclared",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationCountLegacy",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationMapRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationSituation",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationSubAttachmentRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LocationSummary",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccLossAmount",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccNoClaimText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccPremium",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccRatio",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryAccText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryLossAmount",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryLossRatio",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryNoClaimText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "LossHistoryPremium",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "MktAuthorityFormRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "MktAuthorityText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "NetRetentionValue",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "QuotationLocationCount",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ReferralReasonsText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ReferralRequiredFlag",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ReferralType",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "RetentionValue",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "RiArrangementAttachmentRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "RiArrangementText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "RiskGradeTableJson",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "RiskGradeType",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "RiskGradingText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "SpecialAppliedSpec",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "TermsMultiLangJson",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "TreatySurplusValue",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAcceptedDate",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAcceptedFlag",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAccumulatedMetric",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAnnualMetric",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAssessorName",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAttachmentRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAuthorityConditionsText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAuthorityFormRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwAuthorityText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwBusinessStartedYearOrDate",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwCommentText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwCommentsAttachmentRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwEilrAtExpiryMetric",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwEvaluationDetailPictureRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwEvaluationDetailText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwEvaluationTotalScore",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwFormFlag",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwJapaneseNonJapaneseCode",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwLeaderName",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwLeaderUsername",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwLineOfBusinessText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwLossRatioAccumulatedMetric",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwMktCommentText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwOccupationText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwPolicyHolderText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwPortfolioName",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwPricingPictureRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwPricingText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwReferralReasonText",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwReferralType",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "UwRelatedFilesRef",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "AnnualRate",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "BusinessOccupation",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "CfeCode",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ClientCodeJG",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ClientCodePA",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "DiscountPercentOrValue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "EquivalentToCurrency",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ExchangeRateTotalSumIns",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ExchangeRateTotalSumInsVnd",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "Exposure",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "GeoLimitEng",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "GeoLimitViet",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "IarQuotationNo",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "IsCfe",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "IsCfeForm",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PreDiscount",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PreDiscountCommission",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PreDiscountTotal",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PreDiscountVoluntary",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumActual",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumAnnual",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumAnnualTotal",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumCfe",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumCfeAnnual",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumCommission",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumDiscount",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumRate",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumRateAlt",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumRateBI",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumTotal",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumTotalBI",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumTotalBeforeVat",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumVoluntary",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumVoluntaryAnnual",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PremiumVoluntaryValue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ProductDisplayName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "ShowCfe",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "SubLineName",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "SumInsuredBI",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "SumInsuredTotal",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "SumInsuredTotalAlt",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "SumInsuredTotalUsd",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "SumInsuredTotalVnd",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TopRisk",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TopRiskPd",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TotalDue",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TsiBI",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TsiPd",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TsiPdBI",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TsiPdQuotation",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TsiTotal",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "VatAmount",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "VatAmountBI",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "VatPercent",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "VatPercentBI",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "Deductible",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "OccupationCode",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "OccupationFCICode",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "POI",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "PolicyNoCL",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "PremiumRate",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "RiskGrading",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "IssueReqNo",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "IssueReqRefNo",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "IssueRequestCategory",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "IssueStatusCode",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "IssueStatusLabel",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "OverallStatusCode",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ParentRequestId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PmRemarks",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PolicyLanguage",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PolicyPackage",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PolicyPeriodStartDate",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PolicyType",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PrevRemarks",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ResId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "TsRemarks",
                table: "PolicyIssuance");

            migrationBuilder.RenameColumn(
                name: "VATValue",
                table: "QuotationDetails",
                newName: "VatValue");

            migrationBuilder.RenameColumn(
                name: "VAT",
                table: "QuotationDetails",
                newName: "Vat");

            migrationBuilder.RenameColumn(
                name: "BIQtNum",
                table: "QuotationDetails",
                newName: "BiQtNum");

            migrationBuilder.RenameColumn(
                name: "UwSumInsPictureRef",
                table: "QuotationDetails",
                newName: "TmiCode");

            migrationBuilder.RenameColumn(
                name: "UwSumInsLimitText",
                table: "QuotationDetails",
                newName: "IarQuotationNo");

            migrationBuilder.RenameColumn(
                name: "UwSourceName",
                table: "QuotationDetails",
                newName: "CfeCode");

            migrationBuilder.RenameColumn(
                name: "TsiFromBiForm",
                table: "Quotation",
                newName: "QuotationParentCode");

            migrationBuilder.RenameColumn(
                name: "TsiFromBi",
                table: "Quotation",
                newName: "LineCode");

            migrationBuilder.RenameColumn(
                name: "TopRiskPdQuotation",
                table: "Quotation",
                newName: "ClientCode");

            migrationBuilder.RenameColumn(
                name: "TopRiskPdBI",
                table: "Quotation",
                newName: "BusinessOccupationName");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Quotation",
                newName: "QuotationQuantity");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                table: "Quotation",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "TnCs",
                table: "PolicyIssuanceDetails",
                newName: "Reason");

            migrationBuilder.RenameColumn(
                name: "TheInsured",
                table: "PolicyIssuanceDetails",
                newName: "PolicyPackage");

            migrationBuilder.RenameColumn(
                name: "TSI",
                table: "PolicyIssuanceDetails",
                newName: "LanguageOfPolicy");

            migrationBuilder.RenameColumn(
                name: "SumInsuredBreakdown",
                table: "PolicyIssuanceDetails",
                newName: "HoldCoverType");

            migrationBuilder.RenameColumn(
                name: "QuotationCodeAlt",
                table: "PolicyIssuance",
                newName: "QuotationParentCode");

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "QuotationSubDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Vat",
                table: "QuotationDetails",
                type: "float",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ActualDays",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClauseId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CurrencyId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeductibleId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ExchangeRate",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InstallmentId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCfe",
                table: "QuotationDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<double>(
                name: "PremiumCfe",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PremiumRate",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PremiumTotal",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PremiumTotalBeforeVat",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PremiumVoluntary",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCfe",
                table: "QuotationDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<double>(
                name: "SumInsuredTotal",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SumInsuredTotalUsd",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TopRiskPd",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TopRiskPdQuotation",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalDue",
                table: "QuotationDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PolicyNo",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyNo",
                table: "PolicyIssuanceSubDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuotationCode",
                table: "PolicyIssuanceSubDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodInsuranceEndDate",
                table: "PolicyIssuanceDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodInsuranceStartDate",
                table: "PolicyIssuanceDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PolicyIssuanceCode",
                table: "PolicyIssuance",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PIC",
                table: "PolicyIssuance",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "QuotationSubDetails");

            migrationBuilder.DropColumn(
                name: "ClauseId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "DeductibleId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "InstallmentId",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "IsCfe",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PremiumCfe",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PremiumRate",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PremiumTotal",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PremiumTotalBeforeVat",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PremiumVoluntary",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "ShowCfe",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "SumInsuredTotal",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "SumInsuredTotalUsd",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "TopRiskPd",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "TopRiskPdQuotation",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "TotalDue",
                table: "QuotationDetails");

            migrationBuilder.DropColumn(
                name: "PolicyNo",
                table: "PolicyIssuanceSubDetails");

            migrationBuilder.DropColumn(
                name: "QuotationCode",
                table: "PolicyIssuanceSubDetails");

            migrationBuilder.DropColumn(
                name: "PeriodInsuranceEndDate",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "PeriodInsuranceStartDate",
                table: "PolicyIssuanceDetails");

            migrationBuilder.RenameColumn(
                name: "VatValue",
                table: "QuotationDetails",
                newName: "VATValue");

            migrationBuilder.RenameColumn(
                name: "Vat",
                table: "QuotationDetails",
                newName: "VAT");

            migrationBuilder.RenameColumn(
                name: "BiQtNum",
                table: "QuotationDetails",
                newName: "BIQtNum");

            migrationBuilder.RenameColumn(
                name: "TmiCode",
                table: "QuotationDetails",
                newName: "UwSumInsPictureRef");

            migrationBuilder.RenameColumn(
                name: "IarQuotationNo",
                table: "QuotationDetails",
                newName: "UwSumInsLimitText");

            migrationBuilder.RenameColumn(
                name: "CfeCode",
                table: "QuotationDetails",
                newName: "UwSourceName");

            migrationBuilder.RenameColumn(
                name: "QuotationQuantity",
                table: "Quotation",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "QuotationParentCode",
                table: "Quotation",
                newName: "TsiFromBiForm");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Quotation",
                newName: "CurrencyId");

            migrationBuilder.RenameColumn(
                name: "LineCode",
                table: "Quotation",
                newName: "TsiFromBi");

            migrationBuilder.RenameColumn(
                name: "ClientCode",
                table: "Quotation",
                newName: "TopRiskPdQuotation");

            migrationBuilder.RenameColumn(
                name: "BusinessOccupationName",
                table: "Quotation",
                newName: "TopRiskPdBI");

            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "PolicyIssuanceDetails",
                newName: "TnCs");

            migrationBuilder.RenameColumn(
                name: "PolicyPackage",
                table: "PolicyIssuanceDetails",
                newName: "TheInsured");

            migrationBuilder.RenameColumn(
                name: "LanguageOfPolicy",
                table: "PolicyIssuanceDetails",
                newName: "TSI");

            migrationBuilder.RenameColumn(
                name: "HoldCoverType",
                table: "PolicyIssuanceDetails",
                newName: "SumInsuredBreakdown");

            migrationBuilder.RenameColumn(
                name: "QuotationParentCode",
                table: "PolicyIssuance",
                newName: "QuotationCodeAlt");

            migrationBuilder.AlterColumn<long>(
                name: "VAT",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ActualDays",
                table: "QuotationDetails",
                type: "float",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaimSettlementBasisText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClauseName",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsuranceOutValue",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsuranceShareValue",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoInsurerName",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deductible",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeductibleFire",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DutyOfDisclosureText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationDetailPictureRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationDetailText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EvaluationTotalScore",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JurisdictionLawText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LimitOfLiability",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationAttachmentRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountActual",
                table: "QuotationDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountActualAlt",
                table: "QuotationDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountAnnual",
                table: "QuotationDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountDeclared",
                table: "QuotationDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCountLegacy",
                table: "QuotationDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationMapRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationSituation",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationSubAttachmentRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationSummary",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryAccLossAmount",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistoryAccNoClaimText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryAccPremium",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryAccRatio",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistoryAccText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryLossAmount",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryLossRatio",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistoryNoClaimText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LossHistoryPremium",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MktAuthorityFormRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MktAuthorityText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetRetentionValue",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuotationLocationCount",
                table: "QuotationDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferralReasonsText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferralRequiredFlag",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferralType",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RetentionValue",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiArrangementAttachmentRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiArrangementText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskGradeTableJson",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskGradeType",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskGradingText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialAppliedSpec",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TermsMultiLangJson",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatySurplusValue",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UwAcceptedDate",
                table: "QuotationDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAcceptedFlag",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAccumulatedMetric",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAnnualMetric",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAssessorName",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAttachmentRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAuthorityConditionsText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAuthorityFormRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwAuthorityText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwBusinessStartedYearOrDate",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwCommentText",
                table: "QuotationDetails",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwCommentsAttachmentRef",
                table: "QuotationDetails",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwEilrAtExpiryMetric",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwEvaluationDetailPictureRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwEvaluationDetailText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UwEvaluationTotalScore",
                table: "QuotationDetails",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwFormFlag",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwJapaneseNonJapaneseCode",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLeaderName",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLeaderUsername",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLineOfBusinessText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwLossRatioAccumulatedMetric",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwMktCommentText",
                table: "QuotationDetails",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwOccupationText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPolicyHolderText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPortfolioName",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPricingPictureRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwPricingText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwReferralReasonText",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwReferralType",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UwRelatedFilesRef",
                table: "QuotationDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PolicyNo",
                table: "Quotation",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AnnualRate",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessOccupation",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CfeCode",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCodeJG",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCodePA",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiscountPercentOrValue",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquivalentToCurrency",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateTotalSumIns",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateTotalSumInsVnd",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exposure",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeoLimitEng",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeoLimitViet",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IarQuotationNo",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsCfe",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsCfeForm",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PreDiscount",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PreDiscountCommission",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PreDiscountTotal",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PreDiscountVoluntary",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumActual",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumAnnual",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumAnnualTotal",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumCfe",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumCfeAnnual",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumCommission",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumDiscount",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumRate",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumRateAlt",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumRateBI",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PremiumTotal",
                table: "Quotation",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumTotalBI",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PremiumTotalBeforeVat",
                table: "Quotation",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumVoluntary",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumVoluntaryAnnual",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PremiumVoluntaryValue",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDisplayName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShowCfe",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubLineName",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SumInsuredBI",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SumInsuredTotal",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SumInsuredTotalAlt",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SumInsuredTotalUsd",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SumInsuredTotalVnd",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopRisk",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopRiskPd",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalDue",
                table: "Quotation",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TsiBI",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TsiPd",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TsiPdBI",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TsiPdQuotation",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TsiTotal",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "VatAmount",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "VatAmountBI",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "VatPercent",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "VatPercentBI",
                table: "Quotation",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deductible",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "Occupation",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "OccupationCode",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "OccupationFCICode",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "POI",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "PolicyNoCL",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "Premium",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "PremiumRate",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "RiskGrading",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AlterColumn<string>(
                name: "PolicyIssuanceCode",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PIC",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssueReqNo",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssueReqRefNo",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssueRequestCategory",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssueStatusCode",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssueStatusLabel",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LineId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "PolicyIssuance",
                type: "bigint",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OverallStatusCode",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentRequestId",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PmRemarks",
                table: "PolicyIssuance",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyLanguage",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyPackage",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PolicyPeriodStartDate",
                table: "PolicyIssuance",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyType",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevRemarks",
                table: "PolicyIssuance",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "PolicyIssuance",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ResId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TsRemarks",
                table: "PolicyIssuance",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);
        }
    }
}
