using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_protection_detail_make_grid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "ProtectionDetail",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "CoverAreasRemarks",
                table: "ProtectionDetail",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FirefightingEquipmentId",
                table: "ProtectionDetail",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "ProtectionDetail");

            migrationBuilder.DropColumn(
                name: "CoverAreasRemarks",
                table: "ProtectionDetail");

            migrationBuilder.DropColumn(
                name: "FirefightingEquipmentId",
                table: "ProtectionDetail");
        }
    }
}
