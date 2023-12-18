using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LT.DigitalOffice.ScheduleService.Data.Provider.MsSql.Ef.Migrations;

[DbContext(typeof(ScheduleServiceDbContext))]
[Migration("20231217210755_InitialCreate")]
public class InitialCreate : Migration
{
  #region Create tables

  private void CreateTableGroups(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.CreateTable(
      name: DbGroup.TableName,
      columns: table => new
      {
        Id = table.Column<Guid>(nullable: false),
        Name = table.Column<string>(nullable: false, maxLength: 50),
      },
      constraints: table =>
      {
        table.PrimaryKey($"PK_{DbGroup.TableName}", x => x.Id);
        //table.UniqueConstraint($"UX_{DbGroup.TableName}_Name_unique", x => x.Name);
      });
  }

  private void CreateTableGroupsUsers(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.CreateTable(
      name: DbGroupsUser.TableName,
      columns: table => new
      {
        GroupId = table.Column<Guid>(nullable: false),
        UserId = table.Column<Guid>(nullable: false),
      },
      constraints: table =>
      {
        table.PrimaryKey($"PK_{DbGroupsUser.TableName}", x => new { x.GroupId, x.UserId });
      });
  }

  private void CreateTableWorkspaces(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.CreateTable(
      name: DbWorkspace.TableName,
      columns: table => new
      {
        Id = table.Column<Guid>(nullable: false),
        Name = table.Column<string>(nullable: false, maxLength: 100),
      },
      constraints: table =>
      {
        table.PrimaryKey($"PK_{DbWorkspace.TableName}", x => x.Id);
      });
  }

  private void CreateTableCategories(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.CreateTable(
      name: DbCategory.TableName,
      columns: table => new
      {
        Id = table.Column<Guid>(nullable: false),
        Name = table.Column<string>(nullable: false, maxLength: 20),
        Color = table.Column<string>(nullable: false, maxLength: 50),
      },
      constraints: table =>
      {
        table.PrimaryKey($"PK_{DbCategory.TableName}", x => x.Id);
      });
  }

  private void CreateTableTasks(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.CreateTable(
      name: DbTask.TableName,
      columns: table => new
      {
        Id = table.Column<Guid>(nullable: false),
        Name = table.Column<string>(nullable: false, maxLength: 20),
        Description = table.Column<string>(nullable: false, maxLength: 300),
        Type = table.Column<int>(nullable: false),
        GroupId = table.Column<Guid>(nullable: false),
        WorkspaceId = table.Column<Guid>(nullable: false),
      },
      constraints: table =>
      {
        table.PrimaryKey($"PK_{DbTask.TableName}", x => x.Id);
      });
  }

  private void CreateTableCategoriesTasks(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.CreateTable(
      name: DbCategoriesTask.TableName,
      columns: table => new
      {
        TaskId = table.Column<Guid>(nullable: false),
        CategoryId = table.Column<Guid>(nullable: false),
      },
      constraints: table =>
      {
        table.PrimaryKey($"PK_{DbCategoriesTask.TableName}", x => new { x.TaskId, x.CategoryId });
      });
  }

  #endregion

  protected override void Up(MigrationBuilder migrationBuilder)
  {
    CreateTableGroups(migrationBuilder);

    CreateTableGroupsUsers(migrationBuilder);

    CreateTableWorkspaces(migrationBuilder);

    CreateTableCategories(migrationBuilder);

    CreateTableTasks(migrationBuilder);

    CreateTableCategoriesTasks(migrationBuilder);
  }

  protected override void Down(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.DropTable(DbGroup.TableName);

    migrationBuilder.DropTable(DbGroupsUser.TableName);

    migrationBuilder.DropTable(DbWorkspace.TableName);

    migrationBuilder.DropTable(DbCategory.TableName);

    migrationBuilder.DropTable(DbTask.TableName);

    migrationBuilder.DropTable(DbCategoriesTask.TableName);
  }
}