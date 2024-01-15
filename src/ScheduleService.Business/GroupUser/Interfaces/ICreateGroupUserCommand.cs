using LT.DigitalOffice.Kernel.Responses;
using System.Threading.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.Kernel.Attributes;
using System;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;

[AutoInject]
public interface ICreateGroupUserCommand
{
  Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateGroupUserRequest request);
}
