using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class system_build_base_attribs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "EnumData",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "EnumData",
                newName: "ModifiedBy");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "SysTable",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SysTable",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SysTable",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "SysTable",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "SysTable",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "SysTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "SysTable",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "SysTable",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SysTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Menu",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Menu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Menu",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Menu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "EnumData",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "EnumData",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "EnumData",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "EnumData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "EnumData",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DataGridConfig",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DataGridConfig",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DataGridConfig",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "DataGridConfig",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "DataGridConfig",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "DataGridConfig",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "DataGridConfig",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "DataGridConfig",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SysTable");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "EnumData");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "DataGridConfig");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "DataGridConfig");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "EnumData",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "EnumData",
                newName: "LastModifiedBy");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SysTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Menu",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "EnumData",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
