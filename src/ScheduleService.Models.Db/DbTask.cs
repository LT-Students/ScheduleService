using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbTask
{
  public const string TableName = "Tasks";

  public Guid Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public int Type { get; set; } //enum
  public Guid GroupId { get; set; }
  public Guid WorkspaceId { get; set; }

  public DbGroup Group { get; set; }
  public DbWorkspace Workspace { get; set; }
  public IList<DbCategory> Categories { get; set; } = new List<DbCategory>();
}

public class DbTaskConfiguration : IEntityTypeConfiguration<DbTask>
{
  public void Configure(EntityTypeBuilder<DbTask> builder)
  {
    builder
      .ToTable(DbTask.TableName);

    builder
      .HasKey(a => a.Id);

    builder
      .HasOne(u => u.Group)
      .WithMany(o => o.Tasks)
      .HasForeignKey(u => u.GroupId)
      .HasPrincipalKey(o => o.Id);

    builder
      .HasOne(u => u.Workspace)
      .WithMany(o => o.Tasks)
      .HasForeignKey(u => u.WorkspaceId)
      .HasPrincipalKey(o => o.Id);
  }
}