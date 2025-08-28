using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Models.Migrations
{
    /// <inheritdoc />
    public partial class Wording_Add_SystemNote_Modify_Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Construction",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "LossHistory",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "Management",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "Occupancy",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "REOpinions",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "UWSurveyId",
                table: "Wording");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Wording",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Wording",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UWWordingMap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    UWSurveyId = table.Column<int>(type: "int", nullable: true),
                    REOpinions = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Management = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Occupancy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Construction = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    LossHistory = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UWWordingMap", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UWWordingMap");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Wording");

            migrationBuilder.AddColumn<string>(
                name: "Construction",
                table: "Wording",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LossHistory",
                table: "Wording",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Management",
                table: "Wording",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupancy",
                table: "Wording",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REOpinions",
                table: "Wording",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UWSurveyId",
                table: "Wording",
                type: "int",
                nullable: true);
        }
    }
}
