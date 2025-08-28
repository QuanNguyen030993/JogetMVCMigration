using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class outline_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OccupancyDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InstalledPosition = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    TechnicalSpec = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    UtilityTypeId = table.Column<long>(type: "bigint", nullable: true),
                    IndGasSupTypeId = table.Column<long>(type: "bigint", nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    Capacity = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IndGasSupCategoryTypeId = table.Column<long>(type: "bigint", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupancyDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outline",
                columns: table => new
                {
                    OutlineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FontStyle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FontSize = table.Column<int>(type: "int", nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsBold = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsItalic = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsUnderline = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outline", x => x.OutlineId);
                    table.ForeignKey(
                        name: "FK_Outline_Outline_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Outline",
                        principalColumn: "OutlineId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Outline_ParentId",
                table: "Outline",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OccupancyDetail");

            migrationBuilder.DropTable(
                name: "Outline");
        }
    }
}
