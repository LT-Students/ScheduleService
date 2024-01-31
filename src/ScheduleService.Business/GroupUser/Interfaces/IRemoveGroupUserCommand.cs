using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;

[AutoInject]
public interface IRemoveGroupUserCommand
{
  Task<OperationResultResponse<bool>> ExecuteAsync(Guid id);
}
