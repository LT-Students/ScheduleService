using LT.DigitalOffice.Kernel.Responses;
using System.Threading.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.GroupUser;
using LT.DigitalOffice.Kernel.Attributes;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;

[AutoInject]
public interface ICreateGroupUserCommand
{
  Task<OperationResultResponse<CreateGroupUserResponse>> ExecuteAsync(CreateGroupUserRequest request);
}
