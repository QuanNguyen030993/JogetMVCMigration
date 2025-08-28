using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class mofidy_protection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoSprinklerSystemContent",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "FireAlarmSystemsContent",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "FireExtingSystemContent",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "FireHydrantsHoseReelsContent",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "FirePumpsContent",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "FireWaterSupplyContent",
                table: "Protection");

            migrationBuilder.DropColumn(
                name: "GasDetectionSystemContent",
                table: "Protection");

            migrationBuilder.RenameColumn(
                name: "PublicFireBrigadeContent",
                table: "Protection",
                newName: "PublicFireBrigade");

            migrationBuilder.RenameColumn(
                name: "InHouseFireBrigadeContent",
                table: "Protection",
                newName: "MaintenanceProgram");

            // migrationBuilder.AddColumn<string>(
            //     name: "ProductionProcessContent",
            //     table: "Occupancy",
            //     type: "nvarchar(max)",
            //     maxLength: 8000,
            //     nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductionProcessContent",
                table: "Occupancy");

            migrationBuilder.RenameColumn(
                name: "PublicFireBrigade",
                table: "Protection",
                newName: "PublicFireBrigadeContent");

            migrationBuilder.RenameColumn(
                name: "MaintenanceProgram",
                table: "Protection",
                newName: "InHouseFireBrigadeContent");

            migrationBuilder.AddColumn<string>(
                name: "AutoSprinklerSystemContent",
                table: "Protection",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FireAlarmSystemsContent",
                table: "Protection",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FireExtingSystemContent",
                table: "Protection",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FireHydrantsHoseReelsContent",
                table: "Protection",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirePumpsContent",
                table: "Protection",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FireWaterSupplyContent",
                table: "Protection",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GasDetectionSystemContent",
                table: "Protection",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }
    }
}
