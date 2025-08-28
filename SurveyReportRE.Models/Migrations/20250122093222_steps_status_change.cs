using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class steps_status_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToStatusId",
                table: "StepsWorkflow",
                newName: "PositiveStatusId");

            migrationBuilder.RenameColumn(
                name: "FromStatusId",
                table: "StepsWorkflow",
                newName: "NegativeStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositiveStatusId",
                table: "StepsWorkflow",
                newName: "ToStatusId");

            migrationBuilder.RenameColumn(
                name: "NegativeStatusId",
                table: "StepsWorkflow",
                newName: "FromStatusId");
        }
    }
}
