using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class build_tables_PK_dataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Wording");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Wording",
                newName: "WordingName");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Wording",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Wording",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Location",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Location",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Location",
                newName: "LocaltionName");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Location",
                newName: "LocationAddress");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Employee",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Employee",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "ClientLocationDetail",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "ClientLocationDetail",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Client",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Client",
                newName: "ModifiedBy");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Wording",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Wording",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Wording",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Wording",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "BranchId",
                table: "Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Location",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Location",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Location",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProvinceId",
                table: "Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Employee",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Employee",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "ClientLocationDetail",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ClientLocationDetail",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "ClientLocationDetail",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "ClientLocationDetail",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Client",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ClientAddress",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCode",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Client",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Client",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Client",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Wording");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "ClientLocationDetail");

            migrationBuilder.DropColumn(
                name: "ClientAddress",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientCode",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "WordingName",
                table: "Wording",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Wording",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Wording",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Location",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Location",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LocationAddress",
                table: "Location",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "LocaltionName",
                table: "Location",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Employee",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Employee",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "ClientLocationDetail",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "ClientLocationDetail",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Client",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Client",
                newName: "LastModifiedBy");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Wording",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Wording",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Location",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientLocationDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Client",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
