using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbCategory
{
  public const string TableName = "Categories";

  public Guid Id { get; set; }
  public string Name { get; set; }
  public string Color { get; set; }
}

public class DbCategoryConfiguration : IEntityTypeConfiguration<DbCategory>
{
  public void Configure(EntityTypeBuilder<DbCategory> builder)
  {
    builder
      .ToTable(DbCategory.TableName);

    builder
      .HasKey(a => a.Id);
  }
}