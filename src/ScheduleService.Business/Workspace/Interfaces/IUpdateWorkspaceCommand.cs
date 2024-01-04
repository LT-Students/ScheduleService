using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;

[AutoInject]
public interface IUpdateWorkspaceCommand
{
  Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, UpdateWorkspaceRequest request);
}
