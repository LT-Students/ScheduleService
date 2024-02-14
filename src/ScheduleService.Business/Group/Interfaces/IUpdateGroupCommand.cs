using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;

[AutoInject]
public interface IUpdateGroupCommand
{
  Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, EditGroupRequest request);
}
