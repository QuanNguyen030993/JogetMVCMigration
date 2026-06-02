using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class status_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "StatusId",
                table: "Quotation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StatusId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "PolicyIssuance");
        }
    }
}
