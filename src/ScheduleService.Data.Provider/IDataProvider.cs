using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.EFSupport.Provider;
using LT.DigitalOffice.Kernel.Enums;
using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace LT.DigitalOffice.ScheduleService.Data.Provider;

[AutoInject(InjectType.Scoped)]
public interface IDataProvider : IBaseDataProvider
{
  DbSet<DbCategory> Categories { get; set; }

  DbSet<DbGroup> Groups { get; set; }

  DbSet<DbGroupsUser> GroupsUsers { get; set; }

  DbSet<DbTask> Tasks { get; set; }

  DbSet<DbWorkspace> Workspaces { get; set; }
}