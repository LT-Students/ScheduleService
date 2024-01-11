using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class EditGroupUserCommand : IEditGroupUserCommand
{
  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, EditGroupUserRequest request)
  {
    throw new System.NotImplementedException();
  }
}
