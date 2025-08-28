using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class grantsurvey_change_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GrantSurvey",
                table: "Survey",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DataGridConfigDynamic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowGrouping = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    AllowHeaderFiltering = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    Caption = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DataField = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DataType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FormDataType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    EditorOptions = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FormItem = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CalculateFilterExpression = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    SysTableId = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    FormGroupName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    GridGroupName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    GridVisibleIndex = table.Column<int>(type: "int", nullable: true),
                    FormVisibleIndex = table.Column<int>(type: "int", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ValidationRules = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Fixed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    FixedPosition = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CSSClass = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Width = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Height = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FormWidth = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FormHeight = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    MappingFieldId = table.Column<long>(type: "bigint", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataGridConfigDynamic", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataGridConfigDynamic");

            migrationBuilder.AlterColumn<byte[]>(
                name: "GrantSurvey",
                table: "Survey",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);
        }
    }
}
