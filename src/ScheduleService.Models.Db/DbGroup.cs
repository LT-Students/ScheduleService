using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbGroup
{
  public const string TableName = "Groups";

  public Guid Id { get; set; }
  public string Name { get; set; }
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
      .HasKey(a => a.Id);

    builder
      .HasMany(u => u.Tasks)
      .WithOne(o => o.Group)
      .HasForeignKey(u => u.GroupId)
      .HasPrincipalKey(o => o.Id);

    builder
      .HasMany(u => u.GroupsUsers)
      .WithOne(o => o.Group)
      .HasForeignKey(u => u.GroupId)
      .HasPrincipalKey(o => o.Id);
  }
}