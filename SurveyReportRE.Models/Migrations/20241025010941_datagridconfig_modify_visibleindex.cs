using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class datagridconfig_modify_visibleindex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormVisibleIndex",
                table: "DataGridConfig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GridVisibleIndex",
                table: "DataGridConfig",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormVisibleIndex",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "GridVisibleIndex",
                table: "DataGridConfig");
        }
    }
}
