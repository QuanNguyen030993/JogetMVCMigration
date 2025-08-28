using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_width_height : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Size",
                table: "Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "ItemHeight",
                table: "Attachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemWidth",
                table: "Attachment",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemHeight",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "ItemWidth",
                table: "Attachment");

            migrationBuilder.AlterColumn<long>(
                name: "Size",
                table: "Attachment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }
    }
}
