using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class outline_add_system_props : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Outline_Outline_ParentId",
                table: "Outline");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Outline",
                table: "Outline");

            migrationBuilder.DropIndex(
                name: "IX_Outline_ParentId",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "OutlineId",
                table: "Outline");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Outline",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Outline",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Outline",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Outline",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Outline",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Outline",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Outline",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Outline",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Outline",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ParentId1",
                table: "Outline",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Outline",
                table: "Outline",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Outline_ParentId1",
                table: "Outline",
                column: "ParentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Outline_Outline_ParentId1",
                table: "Outline",
                column: "ParentId1",
                principalTable: "Outline",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Outline_Outline_ParentId1",
                table: "Outline");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Outline",
                table: "Outline");

            migrationBuilder.DropIndex(
                name: "IX_Outline_ParentId1",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "ParentId1",
                table: "Outline");

            migrationBuilder.AddColumn<int>(
                name: "OutlineId",
                table: "Outline",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Outline",
                table: "Outline",
                column: "OutlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Outline_ParentId",
                table: "Outline",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Outline_Outline_ParentId",
                table: "Outline",
                column: "ParentId",
                principalTable: "Outline",
                principalColumn: "OutlineId");
        }
    }
}
