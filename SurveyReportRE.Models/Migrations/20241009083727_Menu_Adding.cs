using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Models.Migrations
{
    /// <inheritdoc />
    public partial class Menu_Adding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Action = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    HasItems = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    HasPermission = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    Icon = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
