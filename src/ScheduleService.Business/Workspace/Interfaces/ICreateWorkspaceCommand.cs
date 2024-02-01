using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;

[AutoInject]
public interface ICreateWorkspaceCommand
{
  Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateWorkspaceRequest request);
}
