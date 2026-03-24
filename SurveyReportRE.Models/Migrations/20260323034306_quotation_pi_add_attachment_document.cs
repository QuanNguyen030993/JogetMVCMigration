using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class quotation_pi_add_attachment_document : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AttachmentId",
                table: "Quotation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DocumentId",
                table: "Quotation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AttachmentId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DocumentId",
                table: "PolicyIssuance",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "PolicyIssuance");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "PolicyIssuance");
        }
    }
}
