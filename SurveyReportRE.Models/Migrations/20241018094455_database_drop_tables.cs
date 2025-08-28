using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class database_drop_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_RoleDutyClaimMapping_Claim_ClaimId",
            //    table: "RoleDutyClaimMapping");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_RoleDutyClaimMapping_Duty_DutyId",
            //    table: "RoleDutyClaimMapping");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_RoleDutyMapping_Duty_DutyId",
            //    table: "RoleDutyMapping");

            //migrationBuilder.DropTable(
            //    name: "DutyClaimMapping");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "Duty");

            //migrationBuilder.DropIndex(
            //    name: "IX_RoleDutyMapping_DutyId",
            //    table: "RoleDutyMapping");

            //migrationBuilder.DropIndex(
            //    name: "IX_RoleDutyClaimMapping_ClaimId",
            //    table: "RoleDutyClaimMapping");

            //migrationBuilder.DropIndex(
            //    name: "IX_RoleDutyClaimMapping_DutyId",
            //    table: "RoleDutyClaimMapping");

            //migrationBuilder.DropColumn(
            //    name: "ClaimId",
            //    table: "RoleDutyClaimMapping");

            //migrationBuilder.CreateTable(
            //    name: "Survey",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SurveyNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
            //        LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        InsuredName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        Occupancy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        SurveyedPremises = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        Ownership = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        LatitudeLongitude = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
            //        SurveyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        SurveyedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Survey", x => x.Id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Survey");

            migrationBuilder.AddColumn<int>(
                name: "ClaimId",
                table: "RoleDutyClaimMapping",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Page = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DutyClaimMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    DutyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutyClaimMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DutyClaimMapping_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DutyClaimMapping_Duty_DutyId",
                        column: x => x.DutyId,
                        principalTable: "Duty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleDutyMapping_DutyId",
                table: "RoleDutyMapping",
                column: "DutyId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDutyClaimMapping_ClaimId",
                table: "RoleDutyClaimMapping",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDutyClaimMapping_DutyId",
                table: "RoleDutyClaimMapping",
                column: "DutyId");

            migrationBuilder.CreateIndex(
                name: "IX_DutyClaimMapping_ClaimId",
                table: "DutyClaimMapping",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_DutyClaimMapping_DutyId",
                table: "DutyClaimMapping",
                column: "DutyId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleDutyClaimMapping_Claim_ClaimId",
                table: "RoleDutyClaimMapping",
                column: "ClaimId",
                principalTable: "Claim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleDutyClaimMapping_Duty_DutyId",
                table: "RoleDutyClaimMapping",
                column: "DutyId",
                principalTable: "Duty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleDutyMapping_Duty_DutyId",
                table: "RoleDutyMapping",
                column: "DutyId",
                principalTable: "Duty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
