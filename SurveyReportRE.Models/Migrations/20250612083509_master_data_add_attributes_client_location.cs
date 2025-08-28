using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class master_data_add_attributes_client_location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaName",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuildingName",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictId",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Floor",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hamlet",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Location",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Location",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceId",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetNumber",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WardId",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AreaId",
                table: "Client",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "BuildingName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Hamlet",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Client");
        }
    }
}
