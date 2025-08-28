using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class surveyevalution_update_key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyEvaluationId",
                table: "Survey");

            migrationBuilder.AddColumn<long>(
                name: "SurveyId",
                table: "SurveyEvaluation",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "SurveyEvaluation");

            migrationBuilder.AddColumn<long>(
                name: "SurveyEvaluationId",
                table: "Survey",
                type: "bigint",
                nullable: true);
        }
    }
}
