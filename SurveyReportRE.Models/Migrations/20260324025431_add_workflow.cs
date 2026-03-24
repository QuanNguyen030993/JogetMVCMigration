using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyReportRE.Migrations
{
    /// <inheritdoc />
    public partial class add_workflow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entity",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "FlowMailTemplateId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "NegativeStatusId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "NotifyMailTemplateId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "PositiveStatusId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "ReturnId",
                table: "StepsWorkflow");

            migrationBuilder.RenameColumn(
                name: "Steps",
                table: "StepsWorkflow",
                newName: "SortOrder");

            migrationBuilder.RenameColumn(
                name: "ReturnMailTemplateId",
                table: "StepsWorkflow",
                newName: "StepType");

            migrationBuilder.AddColumn<bool>(
                name: "AllowLoop",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "CanComment",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "CanEdit",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "CanUpload",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentCode",
                table: "StepsWorkflow",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayStatus",
                table: "StepsWorkflow",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlowType",
                table: "StepsWorkflow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<bool>(
                name: "IsEnd",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsStart",
                table: "StepsWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<int>(
                name: "LevelNo",
                table: "StepsWorkflow",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoopGroup",
                table: "StepsWorkflow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ParentStepId",
                table: "StepsWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PosX",
                table: "StepsWorkflow",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PosY",
                table: "StepsWorkflow",
                type: "decimal(28,9)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleCode",
                table: "StepsWorkflow",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StepCode",
                table: "StepsWorkflow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StepName",
                table: "StepsWorkflow",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UiMode",
                table: "StepsWorkflow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkflowDefinitionId",
                table: "StepsWorkflow",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "InstanceWorkflow",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentOwnerRoleCode",
                table: "InstanceWorkflow",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CurrentOwnerUserId",
                table: "InstanceWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CurrentStepId",
                table: "InstanceWorkflow",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "InstanceWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "InstanceWorkflow",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<string>(
                name: "LastActionCode",
                table: "InstanceWorkflow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastFromStepId",
                table: "InstanceWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastToStepId",
                table: "InstanceWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecordType",
                table: "InstanceWorkflow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeToStepId",
                table: "InstanceWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReturnFromStepId",
                table: "InstanceWorkflow",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedDate",
                table: "InstanceWorkflow",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "WorkflowDefinitionId",
                table: "InstanceWorkflow",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ActionWorkflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ActionCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    RequireComment = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RequireAttachment = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsSystemAction = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
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
                    table.PrimaryKey("PK_ActionWorkflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryWorkflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstanceWorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ActionByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActionByRoleCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    ReasonCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReturnFromStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResumeToStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SnapshotJson = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    IsReturn = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsLoop = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    LoopGroup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_HistoryWorkflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransitionWorkflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkflowDefinitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionWorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RequireComment = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RequireAttachment = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RequireAssignee = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ConditionJson = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    SetStatusCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SetOwnerRoleCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsReturn = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsLoop = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    LoopGroup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoopExitMode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaxLoopCount = table.Column<int>(type: "int", nullable: true),
                    IsExitTransition = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    UserDecisionLabel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
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
                    table.PrimaryKey("PK_TransitionWorkflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowDefinition",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkflowCode = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    WorkflowName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FlowType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VersionNo = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
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
                    table.PrimaryKey("PK_WorkflowDefinition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowInstanceNode",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstanceWorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StepWorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NodeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActivatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoopCount = table.Column<int>(type: "int", nullable: false),
                    LastActionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                    table.PrimaryKey("PK_WorkflowInstanceNode", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionWorkflow");

            migrationBuilder.DropTable(
                name: "HistoryWorkflow");

            migrationBuilder.DropTable(
                name: "TransitionWorkflow");

            migrationBuilder.DropTable(
                name: "WorkflowDefinition");

            migrationBuilder.DropTable(
                name: "WorkflowInstanceNode");

            migrationBuilder.DropColumn(
                name: "AllowLoop",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "CanComment",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "CanEdit",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "CanUpload",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "DepartmentCode",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "DisplayStatus",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "FlowType",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "IsEnd",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "IsStart",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "LevelNo",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "LoopGroup",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "ParentStepId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "PosX",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "PosY",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "RoleCode",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "StepCode",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "StepName",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "UiMode",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "WorkflowDefinitionId",
                table: "StepsWorkflow");

            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "CurrentOwnerRoleCode",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "CurrentOwnerUserId",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "CurrentStepId",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "LastActionCode",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "LastFromStepId",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "LastToStepId",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "RecordType",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "ResumeToStepId",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "ReturnFromStepId",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "StartedDate",
                table: "InstanceWorkflow");

            migrationBuilder.DropColumn(
                name: "WorkflowDefinitionId",
                table: "InstanceWorkflow");

            migrationBuilder.RenameColumn(
                name: "StepType",
                table: "StepsWorkflow",
                newName: "ReturnMailTemplateId");

            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "StepsWorkflow",
                newName: "Steps");

            migrationBuilder.AddColumn<string>(
                name: "Entity",
                table: "StepsWorkflow",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FlowMailTemplateId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NegativeStatusId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NotifyMailTemplateId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PositiveStatusId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReturnId",
                table: "StepsWorkflow",
                type: "bigint",
                nullable: true);
        }
    }
}
