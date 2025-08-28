using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class session_user_rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSession",
                table: "UserSession");

            migrationBuilder.RenameTable(
                name: "UserSession",
                newName: "UsersSession");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersSession",
                table: "UsersSession",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersSession",
                table: "UsersSession");

            migrationBuilder.RenameTable(
                name: "UsersSession",
                newName: "UserSession");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSession",
                table: "UserSession",
                column: "Id");
        }
    }
}
