using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_turnaround_both : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TurnAroundTimeAttributes",
                table: "Quotation",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurnAroundTimeAttributes",
                table: "PolicyIssuance",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TurnAroundTimeAttributes",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "TurnAroundTimeAttributes",
                table: "PolicyIssuance");
        }
    }
}
