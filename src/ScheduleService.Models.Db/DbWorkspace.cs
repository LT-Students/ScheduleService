using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbWorkspace
{
  public const string TableName = "Workspaces";

  public Guid Id { get; set; }

  [MaxLength(100)]
  public string Name { get; set; }

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
      .HasKey(a => a.Id);

    builder
      .HasMany(u => u.Tasks)
      .WithOne(o => o.Workspace)
      .HasForeignKey(u => u.WorkspaceId)
      .HasPrincipalKey(o => o.Id);

    builder
      .HasMany(u => u.Groups)
      .WithOne(o => o.Workspace);
  }
}