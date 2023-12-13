using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbTask
{
  public const string TableName = "Tasks";

  public Guid Id { get; set; }

  [MaxLength(20)]
  public string Name { get; set; }

  [MaxLength(300)]
  public string Description { get; set; }

  public int Type { get; set; }

  public Guid GroupId { get; set; }
  public Guid WorkspaceId { get; set; }
}

public class DbTaskConfiguration : IEntityTypeConfiguration<DbTask>
{
  public void Configure(EntityTypeBuilder<DbTask> builder)
  {
    builder
      .ToTable(DbTask.TableName);

    builder
      .HasKey(a => a.Id);
  }
}