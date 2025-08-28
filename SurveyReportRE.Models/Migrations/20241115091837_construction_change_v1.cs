using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class construction_change_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConstructedIn",
                table: "Construction");

            migrationBuilder.DropColumn(
                name: "LayoutContructionArea",
                table: "Construction");

            migrationBuilder.DropColumn(
                name: "LayoutSiteArea",
                table: "Construction");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConstructedIn",
                table: "Construction",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LayoutContructionArea",
                table: "Construction",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LayoutSiteArea",
                table: "Construction",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
