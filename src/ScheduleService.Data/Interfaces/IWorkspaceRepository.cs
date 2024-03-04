using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using System.Threading;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces;

[AutoInject]
public interface IWorkspaceRepository
{
  Task<Guid?> CreateAsync(DbWorkspace board);

  Task<(List<DbWorkspace>, int totalCount)> FindAsync(FindWorkspaceFilter filter, CancellationToken cancellationToken);

  Task<DbWorkspace> GetAsync(Guid id, CancellationToken cancellationToken = default);

  Task<bool> EditAsync(Guid id, Guid modifiedBy, JsonPatchDocument<DbWorkspace> dbWorkspace);

  Task<bool> UpdateAsync(Guid id, Guid ModifiedBy, EditWorkspaceRequest request);

  Task<bool> RemoveAsync(DbWorkspace dbWorkspace, Guid modifiedBy);

  Task<bool> IsWorkspaceExistsAsync(Guid id);

  Task<bool> IsNameExistsAsync(string name, Guid? workspaceId = null, CancellationToken cancellationToken = default);
}
