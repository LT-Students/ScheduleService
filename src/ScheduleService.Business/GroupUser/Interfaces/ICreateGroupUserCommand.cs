using LT.DigitalOffice.Kernel.Responses;
using System.Threading.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.GroupUser;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;

public interface ICreateGroupUserCommand
{
  Task<OperationResultResponse<CreateGroupUserResponse>> ExecuteAsync(CreateGroupUserRequest request);
}
