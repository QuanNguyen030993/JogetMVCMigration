using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class suvey_add_client_location_FK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ClientTypeId",
                table: "Survey",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "0");

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "Survey",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Survey");

            migrationBuilder.AlterColumn<bool>(
                name: "ClientTypeId",
                table: "Survey",
                type: "bit",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }
    }
}
