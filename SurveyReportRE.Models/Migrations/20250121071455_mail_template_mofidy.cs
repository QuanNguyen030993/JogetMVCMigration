using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class mail_template_mofidy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BCC",
                table: "MailTemplate",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CC",
                table: "MailTemplate",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForwardTo",
                table: "MailTemplate",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrefixTitleMail",
                table: "MailTemplate",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemplateMailTitle",
                table: "MailTemplate",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "To",
                table: "MailTemplate",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BCC",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "CC",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "ForwardTo",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "PrefixTitleMail",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "TemplateMailTitle",
                table: "MailTemplate");

            migrationBuilder.DropColumn(
                name: "To",
                table: "MailTemplate");
        }
    }
}
