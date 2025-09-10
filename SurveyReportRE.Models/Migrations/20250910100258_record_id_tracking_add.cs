using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class record_id_tracking_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecordIdTracking",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    record_guid = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_1 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_2 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_3 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_4 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_5 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_6 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_7 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_8 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_9 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    id_10 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    code_list = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    record_type = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    last_change_no = table.Column<int>(type: "int", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_RecordIdTracking", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordIdTracking");
        }
    }
}
