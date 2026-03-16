using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_quotation_add_resid_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuotationId",
                table: "Res");

            migrationBuilder.AddColumn<long>(
                name: "ResId",
                table: "Quotation",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResId",
                table: "Quotation");

            migrationBuilder.AddColumn<string>(
                name: "QuotationId",
                table: "Res",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }
    }
}
