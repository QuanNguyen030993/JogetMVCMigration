using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_stepsWorkflow_TNodeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NodeId",
                table: "StepsWorkflow",
                newName: "TNodeId");

            migrationBuilder.AddColumn<string>(
                name: "FNodeId",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FNodeId",
                table: "StepsWorkflow");

            migrationBuilder.RenameColumn(
                name: "TNodeId",
                table: "StepsWorkflow",
                newName: "NodeId");
        }
    }
}
