using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.GroupUser;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class EditGroupUserCommand : IEditGroupUserCommand
{
  public Task<OperationResultResponse<EditGroupUserResponse>> ExecuteAsync(EditGroupUserRequest request)
  {
    throw new System.NotImplementedException();
  }
}
