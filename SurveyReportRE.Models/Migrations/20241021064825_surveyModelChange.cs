using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class surveyModelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UWSurveyResult");

            migrationBuilder.DropTable(
                name: "UWWordingMap");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Survey",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Survey",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Survey",
                newName: "LocationAddress");

            migrationBuilder.AlterColumn<long>(
                name: "SurveyStatusId",
                table: "Survey",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SurveyNo",
                table: "Survey",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "Survey",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClientTypeId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ConstructionBuildingId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ConstructionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Survey",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Survey",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ExposureId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "HoREOpinionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LineOfBusinessId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LossHistoryId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ManagementId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NaturalHazardId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Survey",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OccupancyId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProtectionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RiskEngineerOpinionId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyFlowStatusId",
                table: "Survey",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TranNo",
                table: "Survey",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ClientTypeId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ConstructionBuildingId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ConstructionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ExposureId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "HoREOpinionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LineOfBusinessId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "LossHistoryId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ManagementId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "NaturalHazardId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "OccupancyId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "ProtectionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "RiskEngineerOpinionId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "SurveyFlowStatusId",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "TranNo",
                table: "Survey");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Survey",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Survey",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LocationAddress",
                table: "Survey",
                newName: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "SurveyStatusId",
                table: "Survey",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SurveyNo",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UWSurveyResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskEvaluationId = table.Column<int>(type: "int", nullable: true),
                    SurveyResultStatusId = table.Column<int>(type: "int", nullable: true),
                    UWSurveyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UWSurveyResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UWWordingMap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Construction = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LossHistory = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Management = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Occupancy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    REOpinions = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UWSurveyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UWWordingMap", x => x.Id);
                });
        }
    }
}
