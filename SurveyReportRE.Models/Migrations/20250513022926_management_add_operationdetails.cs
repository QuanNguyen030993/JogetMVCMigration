using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class management_add_operationdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Export",
                table: "DataGridConfig");

            migrationBuilder.AddColumn<string>(
                name: "OperationDetails",
                table: "Management",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationDetails",
                table: "Management");

            migrationBuilder.AddColumn<string>(
                name: "Export",
                table: "DataGridConfig",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }
    }
}
