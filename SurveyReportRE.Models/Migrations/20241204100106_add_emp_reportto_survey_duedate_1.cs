using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_emp_reportto_survey_duedate_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Survey");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Survey",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Survey");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Survey",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }
    }
}
