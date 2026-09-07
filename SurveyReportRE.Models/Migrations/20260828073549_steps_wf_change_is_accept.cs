using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class steps_wf_change_is_accept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowLoop",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "CanComment",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "CanEdit",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "CanUpload",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "LoopGroup",
                table: "StepsWorkflow");

            migrationBuilder.AddColumn<bool>(
                name: "IsReturnNeedAccepted",
                table: "StepsWorkflow",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturnNeedAccepted",
                table: "StepsWorkflow");

            migrationBuilder.AddColumn<bool>(
                name: "AllowLoop",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "CanComment",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "CanEdit",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "CanUpload",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "LoopGroup",
                table: "StepsWorkflow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
