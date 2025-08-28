using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class levbd_change_datatype_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValueBrkdwnSum",
                table: "LossExpValueBrkdwnDetail",
                type: "decimal(28,9)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PML",
                table: "LossExpValueBrkdwnDetail",
                type: "decimal(28,9)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ValueBrkdwnSum",
                table: "LossExpValueBrkdwnDetail",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,9)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PML",
                table: "LossExpValueBrkdwnDetail",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,9)",
                oldNullable: true);
        }
    }
}
