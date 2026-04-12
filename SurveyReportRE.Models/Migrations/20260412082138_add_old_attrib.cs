using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_old_attrib : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "is_send",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachments",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromAccount",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
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

            migrationBuilder.AddColumn<string>(
                name: "ToEmail",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToName",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ToEmail",
                table: "MailQueue");

            migrationBuilder.DropColumn(
                name: "ToName",
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

            migrationBuilder.AlterColumn<string>(
                name: "is_send",
                table: "MailQueue",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "attachments",
                table: "MailQueue",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);
        }
    }
}
