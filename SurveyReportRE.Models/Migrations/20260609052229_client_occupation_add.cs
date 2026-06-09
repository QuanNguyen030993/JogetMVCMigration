using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class client_occupation_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BusinessOccupation",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BusinessOccupationId",
                table: "Client",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SourceOfBusinessId",
                table: "Client",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessOccupation",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "BusinessOccupationId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "SourceOfBusinessId",
                table: "Client");
        }
    }
}
