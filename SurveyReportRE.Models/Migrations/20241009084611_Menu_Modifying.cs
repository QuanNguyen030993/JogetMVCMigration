using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Models.Migrations
{
    /// <inheritdoc />
    public partial class Menu_Modifying : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasItems",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "HasPermission",
                table: "Menu");

            migrationBuilder.AddColumn<string>(
                name: "ActionUri",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Menu",
                type: "bit",
                nullable: true,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Controller",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Menu",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<bool>(
                name: "IsMobile",
                table: "Menu",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Menu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parameter",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Menu",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionUri",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Controller",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "IsMobile",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Parameter",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Menu");

            migrationBuilder.AddColumn<bool>(
                name: "HasItems",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "HasPermission",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");
        }
    }
}
