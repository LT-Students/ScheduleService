using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbWorkspace
{
  public const string TableName = "Workspaces";

  public Guid Id { get; set; }
  public string Name { get; set; }
  public Guid CreatedBy { get; set; }
  public DateTime CreatedAtUtc { get; set; }
  public Guid ModifiedBy { get; set; }
  public DateTime ModifiedAtUtc { get; set; }
  public bool IsActive { get; set; }

  public IList<DbGroup> Groups { get; set; } = new List<DbGroup>();
  public IList<DbTask> Tasks { get; set; } = new List<DbTask>();
}

public class DbWorkspaceConfiguration : IEntityTypeConfiguration<DbWorkspace>
{
  public void Configure(EntityTypeBuilder<DbWorkspace> builder)
  {
    builder
      .ToTable(DbWorkspace.TableName);

    builder
      .HasKey(w => w.Id);

    builder
      .HasMany(w => w.Tasks)
      .WithOne(t => t.Workspace)
      .HasForeignKey(t => t.WorkspaceId)
      .HasPrincipalKey(w => w.Id);

    builder
      .HasMany(w => w.Groups)
      .WithOne(g => g.Workspace)
      .HasForeignKey(g => g.WorkspaceId)
      .HasPrincipalKey(w => w.Id);
  }
}