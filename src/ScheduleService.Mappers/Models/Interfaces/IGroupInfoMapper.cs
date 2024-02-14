using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;

[AutoInject]
public interface IGroupInfoMapper
{
  GroupResponse Map(DbGroup dbGroup);
}
