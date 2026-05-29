using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_branch_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BranchId",
                table: "Quotation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BranchId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "PolicyIssuance");
        }
    }
}
