using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbTask
{
  public const string TableName = "Tasks";

  public Guid Id { get; set; }
  public Guid GroupId { get; set; }
  public Guid WorkspaceId { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public int Type { get; set; }
  public Guid CreatedBy { get; set; }
  public DateTime CreatedAtUtc { get; set; }
  public Guid ModifiedBy { get; set; }
  public DateTime ModifiedAtUtc { get; set; }
  public bool IsActive { get; set; }

  public DbGroup Group { get; set; }
  public DbWorkspace Workspace { get; set; }
  public IList<DbCategoriesTask> Categories { get; set; } = new List<DbCategoriesTask>();
}

public class DbTaskConfiguration : IEntityTypeConfiguration<DbTask>
{
  public void Configure(EntityTypeBuilder<DbTask> builder)
  {
    builder
      .ToTable(DbTask.TableName);

    builder
      .HasKey(t => t.Id);

    builder
      .HasOne(t => t.Group)
      .WithMany(g => g.Tasks)
      .HasForeignKey(t => t.GroupId)
      .HasPrincipalKey(g => g.Id);

    builder
      .HasOne(t => t.Workspace)
      .WithMany(w => w.Tasks)
      .HasForeignKey(t => t.WorkspaceId)
      .HasPrincipalKey(w => w.Id);

    builder
      .HasMany(t => t.Categories)
      .WithOne(ct => ct.Task)
      .HasForeignKey(ct => ct.TaskId)
      .HasPrincipalKey(t => t.Id);
  }
}