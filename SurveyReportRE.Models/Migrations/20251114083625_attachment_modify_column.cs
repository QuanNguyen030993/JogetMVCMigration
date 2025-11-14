using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class attachment_modify_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentNote",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "IsDynamicOutline",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "ItemHeight",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "ItemWidth",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "OutlineId",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "RecordGuid",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "SubDirectory",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "Attachment");

            migrationBuilder.RenameColumn(
                name: "SubThumbnailDirectory",
                table: "Attachment",
                newName: "uploaded_by");

            migrationBuilder.RenameColumn(
                name: "SubSitePictureDirectory",
                table: "Attachment",
                newName: "uploaded_at");

            migrationBuilder.RenameColumn(
                name: "SubOverviewDirectory",
                table: "Attachment",
                newName: "table_record_id");

            migrationBuilder.RenameColumn(
                name: "OutlinePlaceholder",
                table: "Attachment",
                newName: "table_name");

            migrationBuilder.AddColumn<string>(
                name: "action_label",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "file_folder",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "file_name",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "file_size",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "is_deleted",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "label_attachment",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "record_guid",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "source_action",
                table: "Attachment",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "action_label",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "file_folder",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "file_name",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "file_size",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "label_attachment",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "record_guid",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "source_action",
                table: "Attachment");

            migrationBuilder.RenameColumn(
                name: "uploaded_by",
                table: "Attachment",
                newName: "SubThumbnailDirectory");

            migrationBuilder.RenameColumn(
                name: "uploaded_at",
                table: "Attachment",
                newName: "SubSitePictureDirectory");

            migrationBuilder.RenameColumn(
                name: "table_record_id",
                table: "Attachment",
                newName: "SubOverviewDirectory");

            migrationBuilder.RenameColumn(
                name: "table_name",
                table: "Attachment",
                newName: "OutlinePlaceholder");

            migrationBuilder.AddColumn<string>(
                name: "AttachmentNote",
                table: "Attachment",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Attachment",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Attachment",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDynamicOutline",
                table: "Attachment",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "Attachment",
                type: "bit",
                nullable: true,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<int>(
                name: "ItemHeight",
                table: "Attachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemWidth",
                table: "Attachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OutlineId",
                table: "Attachment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecordGuid",
                table: "Attachment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "Attachment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubDirectory",
                table: "Attachment",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SurveyId",
                table: "Attachment",
                type: "bigint",
                nullable: true);
        }
    }
}
