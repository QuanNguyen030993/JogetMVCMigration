using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class fill_list_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeriodInsuranceEndDate",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "PeriodInsuranceStartDate",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "ChassisEngineNumber",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "ConfirmedQuotationFlag",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "DeclarationText",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "EmailInformRi",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "FactoryOperationYears",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "FinalPremium",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "Ichigenka",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "IsBodApproved",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "IsGlobalCover",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "IsKycChecked",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "MachineryList",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "NewReplacementValue",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "PremiumBreakdown",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "ProposalForm",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "ResultAttachment",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "RiClosings",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "RiScheme",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "SumInsuredBreakdown",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.DropColumn(
                name: "URFAttachment",
                table: "PolicyIssuanceChecklist");

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "PolicyIssuanceDetails",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<string>(
                name: "FactoryOperationYears",
                table: "PolicyIssuanceDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "EmailMktClient",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "Others",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "PolicyIssuanceDetails",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SumInsuredBreakdown",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailMktClient",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "Others",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "PolicyIssuanceDetails");

            migrationBuilder.DropColumn(
                name: "SumInsuredBreakdown",
                table: "PolicyIssuanceDetails");

            migrationBuilder.AlterColumn<bool>(
                name: "Reason",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FactoryOperationYears",
                table: "PolicyIssuanceDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodInsuranceEndDate",
                table: "PolicyIssuanceDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodInsuranceStartDate",
                table: "PolicyIssuanceDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ChassisEngineNumber",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmedQuotationFlag",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "DeclarationText",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "EmailInformRi",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "FactoryOperationYears",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "FinalPremium",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "Ichigenka",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsBodApproved",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsGlobalCover",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsKycChecked",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "MachineryList",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "NewReplacementValue",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "PremiumBreakdown",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "ProposalForm",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "ResultAttachment",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "RiClosings",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "RiScheme",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "SumInsuredBreakdown",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "URFAttachment",
                table: "PolicyIssuanceChecklist",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");
        }
    }
}
