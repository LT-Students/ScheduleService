using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbCategoriesTask
{
  public const string TableName = "CategoriesTasks";

  public Guid TaskId { get; set; }
  public Guid CategoryId { get; set; }
  public Guid CreatedBy { get; set; }
  public DateTime CreatedAtUtc { get; set; }

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
      .HasKey(ct => new { ct.TaskId, ct.CategoryId });

    builder
      .HasOne(ct => ct.Task)
      .WithMany(t => t.Categories)
      .HasForeignKey(ct => ct.TaskId)
      .HasPrincipalKey(t => t.Id);

    builder
      .HasOne(ct => ct.Category)
      .WithMany(c => c.CategoriesTask)
      .HasForeignKey(ct => ct.CategoryId)
      .HasPrincipalKey(c => c.Id);
  }
}