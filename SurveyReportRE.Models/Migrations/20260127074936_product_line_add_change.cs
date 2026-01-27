using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class product_line_add_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<bool>(
                name: "IsCfe",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsOthers",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<long>(
                name: "LineId",
                table: "Product",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReportLink",
                table: "Product",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReportLink2",
                table: "Product",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ShowBiQuot",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "ShowQuot",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Line",
                type: "bit",
                nullable: false,
                defaultValueSql: "1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsCfe",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsOthers",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ReportLink",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ReportLink2",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShowBiQuot",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShowQuot",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Line");
        }
    }
}
