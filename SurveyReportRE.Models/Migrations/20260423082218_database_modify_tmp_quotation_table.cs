using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class database_modify_tmp_quotation_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PICFO",
                table: "QuotationTmp",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PICLMKT",
                table: "QuotationTmp",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PICPM",
                table: "QuotationTmp",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PICTS",
                table: "QuotationTmp",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PICUW",
                table: "QuotationTmp",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PICFO",
                table: "QuotationTmp");

            migrationBuilder.DropColumn(
                name: "PICLMKT",
                table: "QuotationTmp");

            migrationBuilder.DropColumn(
                name: "PICPM",
                table: "QuotationTmp");

            migrationBuilder.DropColumn(
                name: "PICTS",
                table: "QuotationTmp");

            migrationBuilder.DropColumn(
                name: "PICUW",
                table: "QuotationTmp");
        }
    }
}
