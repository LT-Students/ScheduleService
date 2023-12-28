using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbGroupsTask
{
  public const string TableName = "GroupsTasks";

  public Guid TaskId { get; set; }
  public Guid GroupId { get; set; }

  public DbTask Task { get; set; }
  public DbGroup Group { get; set; }
}

public class DbGroupsTaskConfiguration : IEntityTypeConfiguration<DbGroupsTask>
{
  public void Configure(EntityTypeBuilder<DbGroupsTask> builder)
  {
    builder
      .ToTable(DbGroupsTask.TableName);

    builder
      .HasKey(ct => new { ct.TaskId, ct.GroupId });

    builder
      .HasOne(ct => ct.Task)
      .WithMany(t => t.Groups)
      .HasForeignKey(ct => ct.TaskId)
      .HasPrincipalKey(t => t.Id);

    builder
      .HasOne(ct => ct.Group)
      .WithMany(c => c.Tasks)
      .HasForeignKey(ct => ct.GroupId)
      .HasPrincipalKey(c => c.Id);
  }
}