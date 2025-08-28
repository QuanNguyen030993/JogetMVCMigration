using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_survey_render_flags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NeedPDFConvert",
                table: "Survey",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "WordRendered",
                table: "Survey",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NeedPDFConvert",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "WordRendered",
                table: "Survey");
        }
    }
}
