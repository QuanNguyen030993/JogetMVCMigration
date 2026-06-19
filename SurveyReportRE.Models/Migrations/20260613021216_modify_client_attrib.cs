using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_client_attrib : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FOCode",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "SourceOfBusiness",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "TSCode",
                table: "Client",
                newName: "DisplayName");

            migrationBuilder.AddColumn<long>(
                name: "BusinessOccupationId",
                table: "Client",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClientTypeId",
                table: "Client",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SourceOfBusinessId",
                table: "Client",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                table: "Client",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessOccupationId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientTypeId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "SourceOfBusinessId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "Client",
                newName: "TSCode");

            migrationBuilder.AddColumn<string>(
                name: "FOCode",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SourceOfBusiness",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }
    }
}
