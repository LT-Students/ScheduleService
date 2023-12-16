using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Groups.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class FindGroupCommand : IFindGroupCommand
{
  public Task<OperationResultResponse<FindGroupResponse>> ExecuteAsync(FindGroupRequest request)
  {
    throw new System.NotImplementedException();
  }
}
