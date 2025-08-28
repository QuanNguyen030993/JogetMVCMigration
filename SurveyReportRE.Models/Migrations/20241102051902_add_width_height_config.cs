using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_width_height_config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CSSClass",
                table: "DataGridConfig",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormHeight",
                table: "DataGridConfig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormWidth",
                table: "DataGridConfig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "DataGridConfig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "DataGridConfig",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CSSClass",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "FormHeight",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "FormWidth",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "DataGridConfig");
        }
    }
}
