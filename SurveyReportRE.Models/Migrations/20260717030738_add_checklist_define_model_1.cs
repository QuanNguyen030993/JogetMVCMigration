using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_checklist_define_model_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PMCheck",
                table: "ChecklistDefinition");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "ChecklistDefinition");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PMCheck",
                table: "ChecklistDefinition",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "Result",
                table: "ChecklistDefinition",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");
        }
    }
}
