using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbGroup
{
  public const string TableName = "Groups";

  public Guid Id { get; set; }

  [MaxLength(50)]
  public string Name { get; set; }
}

public class DbGroupConfiguration : IEntityTypeConfiguration<DbGroup>
{
  public void Configure(EntityTypeBuilder<DbGroup> builder)
  {
    builder
      .ToTable(DbGroup.TableName);

    builder
      .HasKey(a => a.Id);
  }
}