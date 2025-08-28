using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class Chart_add_attachmentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChartId",
                table: "Occupancy");

            migrationBuilder.AddColumn<long>(
                name: "AttachmentId",
                table: "Chart",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyId",
                table: "Chart",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Chart");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "Chart");

            migrationBuilder.AddColumn<long>(
                name: "ChartId",
                table: "Occupancy",
                type: "bigint",
                nullable: true);
        }
    }
}
