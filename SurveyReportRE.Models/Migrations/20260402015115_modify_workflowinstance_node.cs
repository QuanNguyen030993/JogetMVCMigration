using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_workflowinstance_node : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StepWorkflowId",
                table: "WorkflowInstanceNode");

            migrationBuilder.AlterColumn<Guid>(
                name: "InstanceWorkflowId",
                table: "WorkflowInstanceNode",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "WorkflowInstanceNode",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkflowDefinitionId",
                table: "WorkflowInstanceNode",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "WorkflowInstanceNode");

            migrationBuilder.DropColumn(
                name: "WorkflowDefinitionId",
                table: "WorkflowInstanceNode");

            migrationBuilder.AlterColumn<Guid>(
                name: "InstanceWorkflowId",
                table: "WorkflowInstanceNode",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StepWorkflowId",
                table: "WorkflowInstanceNode",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
