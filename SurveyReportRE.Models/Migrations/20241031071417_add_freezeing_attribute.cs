using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_freezeing_attribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Fixed",
                table: "DataGridConfig",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "FixedPosition",
                table: "DataGridConfig",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fixed",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "FixedPosition",
                table: "DataGridConfig");
        }
    }
}
