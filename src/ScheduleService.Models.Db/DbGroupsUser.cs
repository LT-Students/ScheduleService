using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbGroupsUser
{
  public const string TableName = "GroupsUsers";

  public Guid GroupId { get; set; }
  public Guid UserId { get; set; }
  public Guid CreatedBy { get; set; }
  public DateTime CreatedAtUtc { get; set; }

  public DbGroup Group { get; set; }
}

public class DbGroupsUserConfiguration : IEntityTypeConfiguration<DbGroupsUser>
{
  public void Configure(EntityTypeBuilder<DbGroupsUser> builder)
  {
    builder
      .ToTable(DbGroupsUser.TableName);

    builder
      .HasKey(gu => new { gu.GroupId, gu.UserId });

    builder
      .HasOne(gu => gu.Group)
      .WithMany(g => g.GroupsUsers)
      .HasForeignKey(gu => gu.GroupId)
      .HasPrincipalKey(g => g.Id);
  }
}