using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class checklist_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deductible",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "OccupationCode",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "OccupationFCICode",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "POI",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "PolicyNoCL",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "PremiumRate",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "RiskGrading",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "TSI",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "TheInsured",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "TnCs",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "PolicyIssuanceChecklist",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NeedToCheck",
                table: "PolicyIssuanceChecklist",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "PolicyIssuanceChecklist",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NeedToCheck",
                table: "PolicyIssuanceChecklist",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deductible",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<long>(
                name: "LineId",
                table: "PolicyIssuanceChecklist",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Occupation",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "OccupationCode",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "OccupationFCICode",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "POI",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "PolicyNoCL",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "Premium",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "PremiumRate",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "PolicyIssuanceChecklist",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RiskGrading",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "TSI",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "TheInsured",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "TnCs",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");
        }
    }
}
