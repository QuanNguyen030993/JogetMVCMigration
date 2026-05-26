using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class adjust_quo_pi_attrib_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PolicyIssuanceChecklist",
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
                    table.PrimaryKey("PK_PolicyIssuanceChecklist", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyIssuanceChecklist");
        }
    }
}
