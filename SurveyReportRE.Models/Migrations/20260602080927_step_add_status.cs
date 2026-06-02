using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class step_add_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusCode",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StatusId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusCode",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "StepsWorkflow");
        }
    }
}
