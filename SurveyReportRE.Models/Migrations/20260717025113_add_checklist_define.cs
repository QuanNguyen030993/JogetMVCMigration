using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_checklist_define : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Checkpoint",
                table: "PolicyIssuanceChecklist",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LineId",
                table: "PolicyIssuanceChecklist",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NeedToCheck",
                table: "PolicyIssuanceChecklist",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PMCheck",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "PolicyIssuanceChecklist",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecordGuid",
                table: "PolicyIssuanceChecklist",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Result",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<int>(
                name: "SequenceNo",
                table: "PolicyIssuanceChecklist",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checkpoint",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "NeedToCheck",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "PMCheck",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "RecordGuid",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "SequenceNo",
                table: "PolicyIssuanceChecklist");
        }
    }
}
