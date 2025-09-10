using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class change_joget_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionDoneQuotationStatus",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompletePI",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompleteQuo",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompletedDate",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateCreatedPM",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateCreatedQT",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstUWthatAcceptedRisk",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MKTFORequestedQuotationBy",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MKTTS",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextActionOnJoget",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextPerson",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PM",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyHolder",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyNumber",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuotationNumber",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestQuotationNumber",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamGroup",
                table: "PendingJoget",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionDoneQuotationStatus",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "CompletePI",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "CompleteQuo",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "DateCreatedPM",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "DateCreatedQT",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "FirstUWthatAcceptedRisk",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "MKTFORequestedQuotationBy",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "MKTTS",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "NextActionOnJoget",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "NextPerson",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "PM",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "PolicyHolder",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "PolicyNumber",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "QuotationNumber",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "RequestQuotationNumber",
                table: "PendingJoget");

            migrationBuilder.DropColumn(
                name: "TeamGroup",
                table: "PendingJoget");
        }
    }
}
