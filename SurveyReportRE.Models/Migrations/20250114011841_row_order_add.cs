using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class row_order_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Wording",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "UserRoles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "UrlCall",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "SysTable",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "SurveyWorkflowHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "SurveyWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "SurveyOutlineOptions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "SurveyMemo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "SurveyEvaluation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Summary",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "SitePictures",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Roles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "ProtectionDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Protection",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "PosNegAspect",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "OutlineDynamic",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Outline",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "OtherExposuresImg",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "OtherExposures",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "OccupancyDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Occupancy",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Menu",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Management",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "MailTemplate",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "LossHistoryDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "LossHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "LossExpValueBrkdwnDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "LossExpValueBrkdwn",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "FormatCodeNo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "ExtFireExpExposures",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "EnumData",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Employee",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "DataGridConfigDynamic",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "DataGridConfig",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "ConstructionBuilding",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Construction",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "ClientLocationDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Client",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Chart",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Attachment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RowOrder",
                table: "Appendix",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "UrlCall");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "SurveyWorkflowHistory");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "SurveyWorkflow");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "SurveyOutlineOptions");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "SurveyMemo");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "SurveyEvaluation");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Summary");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "SitePictures");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "ProtectionDetail");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "PosNegAspect");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "OutlineDynamic");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "OtherExposuresImg");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "OtherExposures");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "OccupancyDetail");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "LossHistoryDetail");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "LossHistory");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "LossExpValueBrkdwnDetail");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "LossExpValueBrkdwn");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "FormatCodeNo");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "ExtFireExpExposures");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "DataGridConfigDynamic");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "ConstructionBuilding");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Construction");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Chart");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "RowOrder",
                table: "Appendix");
        }
    }
}
