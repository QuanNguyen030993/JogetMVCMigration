using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_liststyle_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListStyles",
                table: "Outline");

            migrationBuilder.AddColumn<long>(
                name: "ListStyleId",
                table: "Outline",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListStyleId",
                table: "Outline");

            migrationBuilder.AddColumn<string>(
                name: "ListStyles",
                table: "Outline",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }
    }
}
