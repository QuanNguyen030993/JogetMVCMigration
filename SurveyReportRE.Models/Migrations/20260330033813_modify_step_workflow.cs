using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_step_workflow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionCode",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "StepsWorkflow",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromNodeId",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NodeId",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StepNo",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToNodeId",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionCode",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "FromNodeId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "StepNo",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "ToNodeId",
                table: "StepsWorkflow");
        }
    }
}
