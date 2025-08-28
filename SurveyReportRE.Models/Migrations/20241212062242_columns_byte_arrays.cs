using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class columns_byte_arrays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "GrantSurvey",
                table: "Survey",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "AdditionalOutline",
                table: "OtherExposures",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "AdditionalOutline",
                table: "Occupancy",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "AdditionalOutline",
                table: "Management",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "DataGridConfig",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<byte[]>(
                name: "AdditionalOutline",
                table: "Construction",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrantSurvey",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "AdditionalOutline",
                table: "OtherExposures");

            migrationBuilder.DropColumn(
                name: "AdditionalOutline",
                table: "Occupancy");

            migrationBuilder.DropColumn(
                name: "AdditionalOutline",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "AdditionalOutline",
                table: "Construction");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "DataGridConfig",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
