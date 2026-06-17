using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class update_field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstanceWorkflowId",
                table: "WorkflowInstanceNode");

            migrationBuilder.DropColumn(
                name: "QuotationStatus",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "PolicyIssuanceStatus",
                table: "PolicyIssuance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InstanceWorkflowId",
                table: "WorkflowInstanceNode",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuotationStatus",
                table: "Quotation",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyIssuanceStatus",
                table: "PolicyIssuance",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }
    }
}
