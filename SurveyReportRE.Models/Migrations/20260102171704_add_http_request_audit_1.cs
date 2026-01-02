using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_http_request_audit_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HttpRequestAuditLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraceId = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RequestTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Scheme = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Method = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Path = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    QueryString = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FullUrl = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Action = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    RouteValues = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UserAgent = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Referer = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsAuthenticated = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    AuthenticationType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Claims = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ContentLength = table.Column<long>(type: "bigint", nullable: true),
                    RequestBody = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    ElapsedMilliseconds = table.Column<long>(type: "bigint", nullable: false),
                    HasException = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    Exception = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CustomTags = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Token = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    EncryptMethod = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
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
                    table.PrimaryKey("PK_HttpRequestAuditLog", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HttpRequestAuditLog");
        }
    }
}
