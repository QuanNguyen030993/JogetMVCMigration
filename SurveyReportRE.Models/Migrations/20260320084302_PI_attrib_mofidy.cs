using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class PI_attrib_mofidy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LineId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "PolicyIssuance",
                type: "bigint",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PIC",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyIssuanceStatus",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReinsuranceId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ResId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StageAccount",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StageDept",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkflowStatus",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PIC",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "PolicyIssuanceStatus",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ReinsuranceId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "ResId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "StageAccount",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "StageDept",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "WorkflowStatus",
                table: "PolicyIssuance");
        }
    }
}
