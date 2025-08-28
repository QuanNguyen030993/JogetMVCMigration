using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class construction_building_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "ConstructionBuilding",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberOfStories",
                table: "ConstructionBuilding",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupancy",
                table: "ConstructionBuilding",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pillars",
                table: "ConstructionBuilding",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "ConstructionBuilding");

            migrationBuilder.DropColumn(
                name: "NumberOfStories",
                table: "ConstructionBuilding");

            migrationBuilder.DropColumn(
                name: "Occupancy",
                table: "ConstructionBuilding");

            migrationBuilder.DropColumn(
                name: "Pillars",
                table: "ConstructionBuilding");
        }
    }
}
