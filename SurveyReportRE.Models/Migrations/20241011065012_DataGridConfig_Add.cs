using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Models.Migrations
{
    /// <inheritdoc />
    public partial class DataGridConfig_Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataGridConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowGrouping = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    AllowHeaderFiltering = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DataField = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DataType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    EditorOptions = table.Column<int>(type: "int", nullable: false),
                    FormItem = table.Column<int>(type: "int", nullable: false),
                    CalculateFilterExpression = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataGridConfig", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataGridConfig");
        }
    }
}
