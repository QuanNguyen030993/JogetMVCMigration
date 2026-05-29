using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_pic_in_leader_hod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverageId",
                table: "QuotationDetails");

            migrationBuilder.AddColumn<long>(
                name: "CoverageId",
                table: "QuotationSubDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PIC",
                table: "Quotation",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HODPIC",
                table: "Quotation",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaderPIC",
                table: "Quotation",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HardSoftCopy",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "HODPIC",
                table: "PolicyIssuance",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaderPIC",
                table: "PolicyIssuance",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverageId",
                table: "QuotationSubDetails");

            migrationBuilder.DropColumn(
                name: "HODPIC",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "LeaderPIC",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "HardSoftCopy",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "HODPIC",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "LeaderPIC",
                table: "PolicyIssuance");

            migrationBuilder.AddColumn<long>(
                name: "CoverageId",
                table: "QuotationDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PIC",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);
        }
    }
}
