using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class DeleteGroupUserCommand : IDeleteGroupUserCommand
{
  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    throw new System.NotImplementedException();
  }
}
