using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class draft_guid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Wording",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "UrlCall",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "SysTable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "SurveyWorkflowHistory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "SurveyWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "SurveyOutlineOptions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "SurveyMemo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "SurveyEvaluation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Survey",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Summary",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "SitePictures",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "ProtectionDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Protection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "PosNegAspect",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "ParticipantList",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "OutlineDynamic",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Outline",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "OtherExposuresImg",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "OtherExposures",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "OccupancyDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Occupancy",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Management",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "MailTemplate",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "LossHistoryDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "LossHistory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "LossExpValueBrkdwnDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "LossExpValueBrkdwn",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Location",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "FormatCodeNo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "ExtFireExpExposures",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "EnumData",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "DataGridConfigDynamic",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "DataGridConfig",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "ConstructionBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Construction",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "ClientLocationDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Client",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Chart",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Attachment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DraftGuid",
                table: "Appendix",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "UrlCall");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "SurveyWorkflowHistory");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "SurveyOutlineOptions");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "SurveyMemo");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "SurveyEvaluation");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Summary");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "SitePictures");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "ProtectionDetail");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "PosNegAspect");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "ParticipantList");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "OutlineDynamic");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "OtherExposuresImg");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "OtherExposures");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "OccupancyDetail");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "LossHistoryDetail");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "LossHistory");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "LossExpValueBrkdwnDetail");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "LossExpValueBrkdwn");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "FormatCodeNo");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "ExtFireExpExposures");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "DataGridConfigDynamic");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "ConstructionBuilding");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Construction");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Chart");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "DraftGuid",
                table: "Appendix");
        }
    }
}
