using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class survey_workflow_integrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalBy",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "ApprovalDate",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "SurveyWorkflowId",
                table: "SurveyWorkflow");

            migrationBuilder.AddColumn<string>(
                name: "ApprovalBy",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovalDate",
                table: "Survey",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PDFAttachmentId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WorkflowStatusId",
                table: "Survey",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalBy",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ApprovalDate",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "PDFAttachmentId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "WorkflowStatusId",
                table: "Survey");

            migrationBuilder.AddColumn<string>(
                name: "ApprovalBy",
                table: "SurveyWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovalDate",
                table: "SurveyWorkflow",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "SurveyWorkflow",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "SurveyWorkflow",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StatusId",
                table: "SurveyWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyId",
                table: "SurveyWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyWorkflowId",
                table: "SurveyWorkflow",
                type: "bigint",
                nullable: true);
        }
    }
}
