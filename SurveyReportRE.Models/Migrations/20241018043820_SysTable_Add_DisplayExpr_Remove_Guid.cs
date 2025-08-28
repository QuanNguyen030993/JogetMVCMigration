using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Models.Migrations
{
    /// <inheritdoc />
    public partial class SysTable_Add_DisplayExpr_Remove_Guid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "UWWordingMap");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "UWSurveyResult");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "UWSurvey");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "SurveyResultStatus");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "RiskEvaluation");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Client");

            migrationBuilder.AddColumn<string>(
                name: "DisplayExpr",
                table: "SysTable",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayExpr",
                table: "SysTable");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Wording",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "UWWordingMap",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "UWSurveyResult",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "UWSurvey",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "SurveyResultStatus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "RiskEvaluation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Position",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Location",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "JobTitle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "EnumData",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Department",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "ClientLocationDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Client",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");
        }
    }
}
