using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_turnaround_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TurnAroundTimeConfig",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TATGapDays = table.Column<int>(type: "int", nullable: false),
                    TATTSDays = table.Column<int>(type: "int", nullable: false),
                    NotifyBeforeDays = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_TurnAroundTimeConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurnAroundTimeDeptProcessing",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurnAroundTimeSessionId = table.Column<long>(type: "bigint", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AcceptDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcessingDays = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_TurnAroundTimeDeptProcessing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurnAroundTimeSession",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionNo = table.Column<int>(type: "int", nullable: false),
                    SessionTypeId = table.Column<long>(type: "bigint", nullable: true),
                    SessionStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalDays = table.Column<int>(type: "int", nullable: false),
                    RecordGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_TurnAroundTimeSession", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TurnAroundTimeConfig");

            migrationBuilder.DropTable(
                name: "TurnAroundTimeDeptProcessing");

            migrationBuilder.DropTable(
                name: "TurnAroundTimeSession");
        }
    }
}
