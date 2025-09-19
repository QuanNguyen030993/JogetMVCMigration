using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class mail_queue_change_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAccount",
                table: "MailQueue");

            migrationBuilder.DropColumn(
                name: "HtmlBody",
                table: "MailQueue");

            migrationBuilder.DropColumn(
                name: "IsSend",
                table: "MailQueue");

            migrationBuilder.DropColumn(
                name: "TextBody",
                table: "MailQueue");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "MailQueue",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "MailQueue",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "CC",
                table: "MailQueue",
                newName: "cc");

            migrationBuilder.RenameColumn(
                name: "BCC",
                table: "MailQueue",
                newName: "bcc");

            migrationBuilder.RenameColumn(
                name: "Attachments",
                table: "MailQueue",
                newName: "attachments");

            migrationBuilder.RenameColumn(
                name: "ToName",
                table: "MailQueue",
                newName: "text_body");

            migrationBuilder.RenameColumn(
                name: "ToEmail",
                table: "MailQueue",
                newName: "html_body");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subject",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cc",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bcc",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "from_account",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "is_send",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "to_email",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "to_name",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "from_account",
                table: "MailQueue");

            migrationBuilder.DropColumn(
                name: "is_send",
                table: "MailQueue");

            migrationBuilder.DropColumn(
                name: "to_email",
                table: "MailQueue");

            migrationBuilder.DropColumn(
                name: "to_name",
                table: "MailQueue");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "MailQueue",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "MailQueue",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "cc",
                table: "MailQueue",
                newName: "CC");

            migrationBuilder.RenameColumn(
                name: "bcc",
                table: "MailQueue",
                newName: "BCC");

            migrationBuilder.RenameColumn(
                name: "attachments",
                table: "MailQueue",
                newName: "Attachments");

            migrationBuilder.RenameColumn(
                name: "text_body",
                table: "MailQueue",
                newName: "ToName");

            migrationBuilder.RenameColumn(
                name: "html_body",
                table: "MailQueue",
                newName: "ToEmail");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CC",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BCC",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromAccount",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HtmlBody",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSend",
                table: "MailQueue",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "TextBody",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }
    }
}
