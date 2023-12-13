using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace LT.DigitalOffice.ScheduleService.Models.Db;

public class DbWorkspace
{
  public const string TableName = "Workspaces";

  public Guid Id { get; set; }

  [MaxLength(100)]
  public string Name { get; set; }
}

public class DbWorkspaceConfiguration : IEntityTypeConfiguration<DbWorkspace>
{
  public void Configure(EntityTypeBuilder<DbWorkspace> builder)
  {
    builder
      .ToTable(DbWorkspace.TableName);

    builder
      .HasKey(a => a.Id);
  }
}