using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_nofitication_query_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationQuery",
                table: "Notification");

            migrationBuilder.AddColumn<string>(
                name: "NotificationQuery",
                table: "NotificationTemplate",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationQuery",
                table: "NotificationTemplate");

            migrationBuilder.AddColumn<string>(
                name: "NotificationQuery",
                table: "Notification",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }
    }
}
