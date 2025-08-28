using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_system_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    givenname = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    sn = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    userPrincipalName = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    distinguishedName = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    department = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    branch = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
