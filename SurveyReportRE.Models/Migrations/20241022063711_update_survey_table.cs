using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class update_survey_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfVisit",
                table: "Survey",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "Survey",
                type: "datetime2",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ClientTypeId",
                table: "Survey",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "Construction",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ConstructionBuildingId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ConstructionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exposure",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LineOfBusinessId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistory",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ManagementId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NaturalHazard",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OccupancyId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OtherExposuresId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OtherExposuresImgId",
                table: "Survey",
                type: "bigint",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Protection",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProtectionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyEvaluationId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyFlowStatusId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SurveyNo",
                table: "Survey",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyOverallStatusId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TranNo",
                table: "Survey",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ClientTypeId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Construction",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ConstructionBuildingId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ConstructionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Exposure",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LineOfBusinessId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LossHistory",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ManagementId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "NaturalHazard",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "OccupancyId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "OtherExposuresId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "OtherExposuresImgId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Protection",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ProtectionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyEvaluationId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyFlowStatusId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyNo",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyOverallStatusId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "TranNo",
                table: "Survey");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfVisit",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
