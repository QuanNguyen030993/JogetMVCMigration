using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class occupancy_refactor_cols_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
