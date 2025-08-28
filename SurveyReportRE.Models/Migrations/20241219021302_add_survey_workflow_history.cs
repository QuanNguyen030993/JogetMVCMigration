using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_survey_workflow_history : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Survey");

            migrationBuilder.CreateTable(
                name: "SurveyWorkflowHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
                    SurveyNo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SurveyedBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SubmitBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ApprovalBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecallReason = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    GrantSurvey = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FromWorkflowStatus = table.Column<long>(type: "bigint", nullable: true),
                    ToWorkflowStatus = table.Column<long>(type: "bigint", nullable: true),
                    FromAccount = table.Column<long>(type: "bigint", nullable: true),
                    ToAccount = table.Column<long>(type: "bigint", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyWorkflowHistory", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyWorkflowHistory");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "Survey",
                type: "datetime2",
                nullable: true);
        }
    }
}
