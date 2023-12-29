using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto;
using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models
{
  public class TaskInfoMapper : ITaskInfoMapper
  {
      public TaskInfo Map(DbTask dbTask)
      {
        return dbTask is null
          ? default
          : new TaskInfo
          {
            Id = dbTask.Id,
            Name = dbTask.Name,
            Description = dbTask.Description,
            Type = (TaskType)dbTask.Type,
            WorkspaceId = dbTask.WorkspaceId,
            GroupId = dbTask.GroupId,
          };
      }
  }
}
