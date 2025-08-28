using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_other_exposure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NaturalHazardTypeId",
                table: "OtherExposures");

            migrationBuilder.RenameColumn(
                name: "NaturalHazardTypeContent",
                table: "OtherExposures",
                newName: "Security");

            migrationBuilder.AddColumn<string>(
                name: "NaturalHazardPicContent",
                table: "OtherExposures",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NaturalHazardPicContent",
                table: "OtherExposures");

            migrationBuilder.RenameColumn(
                name: "Security",
                table: "OtherExposures",
                newName: "NaturalHazardTypeContent");

            migrationBuilder.AddColumn<long>(
                name: "NaturalHazardTypeId",
                table: "OtherExposures",
                type: "bigint",
                nullable: true);
        }
    }
}
