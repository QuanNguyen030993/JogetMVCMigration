using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_occupancy_more : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AirCompressor",
                table: "Occupancy",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Boiler",
                table: "Occupancy",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricityCommPowerSupply",
                table: "Occupancy",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricityTransformers",
                table: "Occupancy",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyPowerSupply",
                table: "Occupancy",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChemicalStorageSafety",
                table: "Management",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HotWorks",
                table: "Management",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirCompressor",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "Boiler",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "ElectricityCommPowerSupply",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "ElectricityTransformers",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "EmergencyPowerSupply",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "ChemicalStorageSafety",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "HotWorks",
                table: "Management");
        }
    }
}
