using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;

[AutoInject]
public interface ITaskInfoMapper
{
  TaskInfo Map(DbTask dbTask);
}
