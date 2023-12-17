using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.GroupUser;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;

public interface IDeleteGroupUserCommand
{
  Task<OperationResultResponse<DeleteGroupUserResponse>> ExecuteAsync(DeleteGroupUserRequest request);
}
