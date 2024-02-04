using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models;

public class TaskInfoMapper : ITaskInfoMapper
{
    public TaskResponse Map(DbTask dbTask)
    {
      return dbTask is null
        ? default
        : new TaskResponse
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
