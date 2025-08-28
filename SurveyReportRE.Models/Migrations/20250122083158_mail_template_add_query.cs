using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class mail_template_add_query : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FromStatusId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ToStatusId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromStatusId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "ToStatusId",
                table: "StepsWorkflow");
        }
    }
}
