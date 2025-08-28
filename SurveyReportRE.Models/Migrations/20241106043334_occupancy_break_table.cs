using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class occupancy_break_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "IndGasSupCategoryTypeId",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "IndGasSupTypeId",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "InstalledPosition",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "TechnicalSpec",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "UtilityTypeId",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "ClientAddress",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "ClientCode",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Attachment");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Wording",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "SurveyEvaluation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Survey",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "ProtectionDetail",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Protection",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "PosNegAspect",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "OtherExposuresImg",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "OtherExposures",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Occupancy",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Management",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "LossEstimation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "FormatCodeNo",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "ExtFireExpExposures",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "ConstructionBuilding",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Construction",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "ClientLocationDetail",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Client",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Chart",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Attachment",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Attachment",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<Guid>(
                name: "RecordGuid",
                table: "Attachment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubDirectory",
                table: "Attachment",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "SurveyEvaluation");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "ProtectionDetail");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "PosNegAspect");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "OtherExposuresImg");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "OtherExposures");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "LossEstimation");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "FormatCodeNo");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "ExtFireExpExposures");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "ConstructionBuilding");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Construction");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Chart");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "RecordGuid",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "SubDirectory",
                table: "Attachment");

            migrationBuilder.AddColumn<string>(
                name: "Capacity",
                table: "Occupancy",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IndGasSupCategoryTypeId",
                table: "Occupancy",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IndGasSupTypeId",
                table: "Occupancy",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstalledPosition",
                table: "Occupancy",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "Occupancy",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyId",
                table: "Occupancy",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechnicalSpec",
                table: "Occupancy",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UtilityTypeId",
                table: "Occupancy",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientAddress",
                table: "Attachment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientCode",
                table: "Attachment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientName",
                table: "Attachment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
