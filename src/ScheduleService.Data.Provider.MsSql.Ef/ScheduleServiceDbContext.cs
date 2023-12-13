using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data.Provider.MsSql.Ef;

public class ScheduleServiceDbContext : DbContext, IDataProvider
{
  public DbSet<DbCategory> Categories { get; set; }
  public DbSet<DbGroup> Groups { get; set; }
  public DbSet<DbGroupsUser> GroupsUsers { get; set; }
  public DbSet<DbTask> Tasks { get; set; }
  public DbSet<DbWorkspace> Workspaces { get; set; }

  public ScheduleServiceDbContext(DbContextOptions<ScheduleServiceDbContext> options)
    : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("LT.DigitalOffice.ScheduleService.Models.Db"));
  }

  public void EnsureDeleted()
  {
    Database.EnsureDeleted();
  }

  public bool IsInMemory()
  {
    return Database.IsInMemory();
  }

  public object MakeEntityDetached(object obj)
  {
    Entry(obj).State = EntityState.Detached;
    return Entry(obj).State;
  }

  public void Save()
  {
    SaveChanges();
  }

  public async Task SaveAsync()
  {
    await SaveChangesAsync();
  }
}
