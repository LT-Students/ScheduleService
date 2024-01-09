using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class GetGroupsCommand : IGetGroupsCommand
{
  public Task<OperationResultResponse<FindResultResponse<GroupInfo>>> ExecuteAsync(GetGroupsFilter request)
  {
    throw new System.NotImplementedException();
  }
}
