using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class nodeadddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NodeStatus",
                table: "WorkflowInstanceNode");

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "WorkflowInstanceNode",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "WorkflowInstanceNode");

            migrationBuilder.AddColumn<string>(
                name: "NodeStatus",
                table: "WorkflowInstanceNode",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
