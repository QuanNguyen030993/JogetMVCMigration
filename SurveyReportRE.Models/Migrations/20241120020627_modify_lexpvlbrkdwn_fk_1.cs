using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_lexpvlbrkdwn_fk_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LossEstimate",
                table: "Survey");

            migrationBuilder.AddColumn<long>(
                name: "SurveyId",
                table: "LossExpValueBrkdwnDetail",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "LossExpValueBrkdwnDetail");

            migrationBuilder.AddColumn<string>(
                name: "LossEstimate",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }
    }
}
