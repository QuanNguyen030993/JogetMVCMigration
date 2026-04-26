using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_error_detai_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserAgent",
                table: "ErrorBrowserDetails",
                newName: "Stack");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "ErrorBrowserDetails",
                newName: "ResponseText");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "ErrorBrowserDetails",
                newName: "FunctionName");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "ErrorBrowserDetails",
                newName: "FileName");

            migrationBuilder.RenameColumn(
                name: "ErrorDetails",
                table: "ErrorBrowserDetails",
                newName: "ErrorType");

            migrationBuilder.AddColumn<string>(
                name: "BreadcrumbTrail",
                table: "ErrorBrowserDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColumnNumber",
                table: "ErrorBrowserDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Context",
                table: "ErrorBrowserDetails",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LineNumber",
                table: "ErrorBrowserDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ErrorBrowserDetails",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreadcrumbTrail",
                table: "ErrorBrowserDetails");

            migrationBuilder.DropColumn(
                name: "ColumnNumber",
                table: "ErrorBrowserDetails");

            migrationBuilder.DropColumn(
                name: "Context",
                table: "ErrorBrowserDetails");

            migrationBuilder.DropColumn(
                name: "LineNumber",
                table: "ErrorBrowserDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ErrorBrowserDetails");

            migrationBuilder.RenameColumn(
                name: "Stack",
                table: "ErrorBrowserDetails",
                newName: "UserAgent");

            migrationBuilder.RenameColumn(
                name: "ResponseText",
                table: "ErrorBrowserDetails",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "FunctionName",
                table: "ErrorBrowserDetails",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "ErrorBrowserDetails",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "ErrorType",
                table: "ErrorBrowserDetails",
                newName: "ErrorDetails");
        }
    }
}
