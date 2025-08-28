using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class modify_template_mail_deny_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ReturnId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReturnMailTemplateId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "ReturnMailTemplateId",
                table: "StepsWorkflow");
        }
    }
}
