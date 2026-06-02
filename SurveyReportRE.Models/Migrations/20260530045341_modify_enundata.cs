using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_enundata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "EnumData",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "EnumData");
        }
    }
}
