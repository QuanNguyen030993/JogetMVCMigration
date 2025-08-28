using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_url_call_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrlCall",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Folder = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Module = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Action = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    TypeAction = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    RecordGuidId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Params = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ExpireTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Expired = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
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
                    table.PrimaryKey("PK_UrlCall", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlCall");
        }
    }
}
