using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class try_mail_queue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MailQueue",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToName = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ToEmail = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    TextBody = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    HtmlBody = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    CC = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    BCC = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    FromAccount = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Attachments = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    IsSend = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
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
                    table.PrimaryKey("PK_MailQueue", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MailQueue");
        }
    }
}
