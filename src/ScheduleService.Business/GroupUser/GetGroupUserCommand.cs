using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class GetGroupUserCommand : IGetGroupUserCommand
{
  public Task<OperationResultResponse<GroupUserInfo>> ExecuteAsync(GetGroupUserFilter request)
  {
    throw new System.NotImplementedException();
  }
}
