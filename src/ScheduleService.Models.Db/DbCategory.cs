using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbCategory
{
  public const string TableName = "Categories";

  public Guid Id { get; set; }
  public Guid WorkspaceId { get; set; }
  public string Name { get; set; }
  public CategoryColor Color { get; set; }
  public Guid CreatedBy { get; set; }
  public DateTime CreatedAtUtc { get; set; }
  public Guid? ModifiedBy { get; set; }
  public DateTime? ModifiedAtUtc { get; set; }
  public bool IsActive { get; set; }

  public IList<DbCategoriesTask> CategoriesTask { get; set; } = new List<DbCategoriesTask>();
  public DbWorkspace Workspace { get; set; }
}

public class DbCategoryConfiguration : IEntityTypeConfiguration<DbCategory>
{
  public void Configure(EntityTypeBuilder<DbCategory> builder)
  {
    builder
      .ToTable(DbCategory.TableName);

    builder
      .HasKey(c => c.Id);

    builder
      .HasMany(c => c.CategoriesTask)
      .WithOne(ct => ct.Category)
      .HasForeignKey(ct => ct.CategoryId)
      .HasPrincipalKey(c => c.Id);
  }
}