using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbGroupsUser
{
  public const string TableName = "GroupsUsers";

  public Guid GroupId { get; set; }
  public Guid UserId { get; set; }
}

public class DbGroupsUserConfiguration : IEntityTypeConfiguration<DbGroupsUser>
{
  public void Configure(EntityTypeBuilder<DbGroupsUser> builder)
  {
    builder
      .ToTable(DbGroupsUser.TableName);

    builder
      .HasKey(a => new { a.GroupId, a.UserId });
  }
}