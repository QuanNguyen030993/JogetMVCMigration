using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_policycode_oldclientcodeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OldClientCodeId",
                table: "Client",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyCode",
                table: "Client",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OldClientCodeId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "PolicyCode",
                table: "Client");
        }
    }
}
