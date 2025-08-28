using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class losscontrol_model_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LossControl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    DateOfVisit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LatitudeLongitude = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    LocationAddress = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    SurveyedBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SurveyedByAccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LossControlNo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SurveyedPremises = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Ownership = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ApprovalBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecallReason = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    GrantSurvey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WordRendered = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    PowerPointRendered = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    NeedPDFConvert = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    ClientCode = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    OwnerReport = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SurveyId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_LossControl", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LossControl");
        }
    }
}
