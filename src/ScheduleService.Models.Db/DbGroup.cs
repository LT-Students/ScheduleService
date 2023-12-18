using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbGroup
{
  public const string TableName = "Groups";

  public Guid Id { get; set; }
  public string Name { get; set; }
  public Guid WorkspaceId { get; set; }

  public DbWorkspace Workspace { get; set; }
  public IList<DbGroupsUser> GroupsUsers { get; set; } = new List<DbGroupsUser>();
  public IList<DbTask> Tasks { get; set; } = new List<DbTask>();
}

public class DbGroupConfiguration : IEntityTypeConfiguration<DbGroup>
{
  public void Configure(EntityTypeBuilder<DbGroup> builder)
  {
    builder
      .ToTable(DbGroup.TableName);

    builder
      .HasKey(g => g.Id);

    builder
      .HasMany(g => g.Tasks)
      .WithOne(t => t.Group)
      .HasForeignKey(t => t.GroupId)
      .HasPrincipalKey(g => g.Id);

    builder
      .HasMany(g => g.GroupsUsers)
      .WithOne(gu => gu.Group)
      .HasForeignKey(gu => gu.GroupId)
      .HasPrincipalKey(g => g.Id);

    builder
      .HasOne(g => g.Workspace)
      .WithMany(w => w.Groups)
      .HasForeignKey(g => g.WorkspaceId)
      .HasPrincipalKey(w => w.Id);
  }
}