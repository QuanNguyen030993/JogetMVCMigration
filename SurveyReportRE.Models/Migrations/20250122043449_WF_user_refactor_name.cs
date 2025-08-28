using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class WF_user_refactor_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserWorkflow",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "CheckerUserId",
                table: "UserWorkflow",
                newName: "CheckerUsersId");

            migrationBuilder.RenameColumn(
                name: "ApproverUserId",
                table: "UserWorkflow",
                newName: "ApproverUsersId");

            migrationBuilder.RenameColumn(
                name: "UsersWorkflowId",
                table: "InstanceWorkflow",
                newName: "UserWorkflowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "UserWorkflow",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CheckerUsersId",
                table: "UserWorkflow",
                newName: "CheckerUserId");

            migrationBuilder.RenameColumn(
                name: "ApproverUsersId",
                table: "UserWorkflow",
                newName: "ApproverUserId");

            migrationBuilder.RenameColumn(
                name: "UserWorkflowId",
                table: "InstanceWorkflow",
                newName: "UsersWorkflowId");
        }
    }
}
