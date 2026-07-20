using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class steps_add_notif_mail_template_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MailTemplateId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NotificationTemplateId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MailTemplateId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "NotificationTemplateId",
                table: "StepsWorkflow");
        }
    }
}
