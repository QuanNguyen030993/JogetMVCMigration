using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class copy_from_guid_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Wording",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "UrlCall",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "SysTable",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "SurveyWorkflowHistory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "SurveyWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "SurveyOutlineOptions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "SurveyMemo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "SurveyEvaluation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Survey",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Summary",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "SitePictures",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "ProtectionDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Protection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "PosNegAspect",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "ParticipantList",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "OutlineDynamic",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Outline",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "OtherExposuresImg",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "OtherExposures",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "OccupancyDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Occupancy",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Management",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "MailTemplate",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "LossHistoryDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "LossHistory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "LossExpValueBrkdwnDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "LossExpValueBrkdwn",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Location",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "FormatCodeNo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "ExtFireExpExposures",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "EnumData",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "DataGridConfigDynamic",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "DataGridConfig",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "ConstructionBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Construction",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "ClientLocationDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Client",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Chart",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Attachment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CopyFromGuid",
                table: "Appendix",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "UrlCall");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "SurveyWorkflowHistory");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "SurveyOutlineOptions");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "SurveyMemo");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "SurveyEvaluation");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Summary");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "SitePictures");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "ProtectionDetail");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "PosNegAspect");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "ParticipantList");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "OutlineDynamic");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "OtherExposuresImg");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "OtherExposures");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "OccupancyDetail");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "LossHistoryDetail");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "LossHistory");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "LossExpValueBrkdwnDetail");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "LossExpValueBrkdwn");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "FormatCodeNo");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "ExtFireExpExposures");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "DataGridConfigDynamic");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "ConstructionBuilding");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Construction");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Chart");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "CopyFromGuid",
                table: "Appendix");
        }
    }
}
