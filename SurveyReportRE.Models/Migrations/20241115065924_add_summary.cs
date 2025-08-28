using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_summary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "REOpinion",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SummaryId",
                table: "Survey",
                type: "bigint",
                nullable: true);


            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIntroduction = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    OperationsDetail = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RecentModifications = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ExpansionPlan = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
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
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropColumn(
                name: "REOpinion",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SummaryId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "FirePumpsContent",
                table: "Protection");
        }
    }
}
