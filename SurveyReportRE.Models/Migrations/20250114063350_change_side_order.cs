using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class change_side_order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SideTypeId",
                table: "ParticipantList",
                newName: "SideOrder");

            migrationBuilder.AlterColumn<long>(
                name: "RowOrder",
                table: "ParticipantList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SideOrder",
                table: "ParticipantList",
                newName: "SideTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "RowOrder",
                table: "ParticipantList",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }
    }
}
