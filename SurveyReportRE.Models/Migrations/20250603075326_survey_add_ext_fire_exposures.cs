using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class survey_add_ext_fire_exposures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "AdditionalOutline",
                table: "ExtFireExpExposures",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NaturalHazardPicContent",
                table: "ExtFireExpExposures",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Security",
                table: "ExtFireExpExposures",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurroundingAreas",
                table: "ExtFireExpExposures",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalOutline",
                table: "ExtFireExpExposures");

            migrationBuilder.DropColumn(
                name: "NaturalHazardPicContent",
                table: "ExtFireExpExposures");

            migrationBuilder.DropColumn(
                name: "Security",
                table: "ExtFireExpExposures");

            migrationBuilder.DropColumn(
                name: "SurroundingAreas",
                table: "ExtFireExpExposures");
        }
    }
}
