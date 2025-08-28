using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class survey_action_config_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyActionConfig",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleNo = table.Column<int>(type: "int", nullable: true),
                    RequireInstanceWorkflow = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    StatusKey = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    IsOwnerReport = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsCreatedBy = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    MustDifferentOwner = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    ActionType = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ActionText = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    Priority = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_SurveyActionConfig", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyActionConfig");
        }
    }
}
