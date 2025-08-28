using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_key_lossdetail_and_outline_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LossHistoryId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyTypeId",
                table: "Outline",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LossHistoryId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyTypeId",
                table: "Outline");
        }
    }
}
