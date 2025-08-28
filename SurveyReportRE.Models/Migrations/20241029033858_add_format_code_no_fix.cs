using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_format_code_no_fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormatCodeNo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoSeqCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Smallest = table.Column<int>(type: "int", nullable: true),
                    Largest = table.Column<int>(type: "int", nullable: true),
                    Next = table.Column<int>(type: "int", nullable: true),
                    Format = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SysTableId = table.Column<long>(type: "bigint", nullable: true),
                    DateFormat = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsSysNum = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
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
                    table.PrimaryKey("PK_FormatCodeNo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormatCodeNo");
        }
    }
}
