using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_res_model_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Res",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResRequestNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    QuotationId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DocumentId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    AttachmentId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TmiCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsReferralRequired = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ReferralReason = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAuthorityCondition = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UwAuthorityForm = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiskGrade = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ShowRiskGrade = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    MktProposalComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    UwComment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    UwCommentAttachment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TotalSumInsured = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsTsiCalculated = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TsiPropertyDamage = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TopRiskAmount = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TopRiskPropertyDamage = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsTopRiskCalculated = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Exposure = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Deductible = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    VoluntaryDeductible = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TmivShare = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Retention = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NetRetention = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NetRetentionType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NetRetentionValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TreatySurplus = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CoInsuranceOutward = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SumAssuredType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SumAssuredValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    PropertyTypeList = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Protection = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    MoreInfo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NonAppetiteRisk = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsNonAppetiteRisk = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Capacity = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    HasCapacity = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Construction = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Management = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    OperationYearOfRisk = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CurrentInsurer = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SurveyResult = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    HasSurveyResult = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SurveyResultAttachment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryAcc = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryAccNoClaim = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryAccPremium = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryAccLossAmount = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LossHistoryAccRatio = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiArrangement = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RiArrangementAttachment = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsOthers = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsOthersForm = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ShowNameBizForm = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    BiQuotation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TsiFromBiForm = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
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
                    table.PrimaryKey("PK_Res", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Res");
        }
    }
}
