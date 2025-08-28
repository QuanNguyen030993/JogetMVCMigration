using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_participantlist_length : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SiteTypeId",
                table: "ParticipantList",
                newName: "SideTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "SideName",
                table: "ParticipantList",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SideTypeId",
                table: "ParticipantList",
                newName: "SiteTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "SideName",
                table: "ParticipantList",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);
        }
    }
}
