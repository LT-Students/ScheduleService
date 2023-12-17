using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbCategoriesTask
{
  public const string TableName = "CategoriesTasks";

  public Guid TaskId { get; set; }
  public Guid CategoryId { get; set; }

  public DbTask Task { get; set; }
  public DbCategory Category { get; set; }
}

public class DbCategoriesTaskConfiguration : IEntityTypeConfiguration<DbCategoriesTask>
{
  public void Configure(EntityTypeBuilder<DbCategoriesTask> builder)
  {
    builder
      .ToTable(DbCategoriesTask.TableName);

    builder
      .HasKey(a => new { a.TaskId, a.CategoryId });

    builder
      .HasOne(u => u.Task)
      .WithMany(o => o.Categories)
      .HasForeignKey(u => u.TaskId)
      .HasPrincipalKey(o => o.Id);

    builder
      .HasOne(u => u.Category)
      .WithMany(o => o.CategoriesTask)
      .HasForeignKey(u => u.CategoryId)
      .HasPrincipalKey(o => o.Id);
  }
}