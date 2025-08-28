using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_WF_more_tables_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StepsWorkflowId",
                table: "InstanceWorkflow");

            migrationBuilder.RenameColumn(
                name: "MailTemplateId",
                table: "StepsWorkflow",
                newName: "NotifyMailTemplateId");

            migrationBuilder.AddColumn<string>(
                name: "Entity",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FlowMailTemplateId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entity",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "FlowMailTemplateId",
                table: "StepsWorkflow");

            migrationBuilder.RenameColumn(
                name: "NotifyMailTemplateId",
                table: "StepsWorkflow",
                newName: "MailTemplateId");

            migrationBuilder.AddColumn<long>(
                name: "StepsWorkflowId",
                table: "InstanceWorkflow",
                type: "bigint",
                nullable: true);
        }
    }
}
