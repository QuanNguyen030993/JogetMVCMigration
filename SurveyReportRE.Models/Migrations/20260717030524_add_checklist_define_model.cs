using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_checklist_define_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "PolicyIssuanceChecklist",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "0");

            migrationBuilder.CreateTable(
                name: "ChecklistDefinition",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SequenceNo = table.Column<int>(type: "int", nullable: true),
                    PMCheck = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    Checkpoint = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    NeedToCheck = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Result = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    LineId = table.Column<long>(type: "bigint", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowOrder = table.Column<long>(type: "bigint", nullable: true),
                    CopyFromGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DraftGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistDefinition", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChecklistDefinition");

            migrationBuilder.AlterColumn<bool>(
                name: "Result",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);
        }
    }
}
