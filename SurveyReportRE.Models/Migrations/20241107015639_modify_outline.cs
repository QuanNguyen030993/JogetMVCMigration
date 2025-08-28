using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_outline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Outline_Outline_ParentId1",
                table: "Outline");

            migrationBuilder.DropIndex(
                name: "IX_Outline_ParentId1",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Outline");

            migrationBuilder.DropColumn(
                name: "ParentId1",
                table: "Outline");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Outline",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ParentId1",
                table: "Outline",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Outline_ParentId1",
                table: "Outline",
                column: "ParentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Outline_Outline_ParentId1",
                table: "Outline",
                column: "ParentId1",
                principalTable: "Outline",
                principalColumn: "Id");
        }
    }
}
