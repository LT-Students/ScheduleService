using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.Kernel.Attributes;
using System.Threading;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces;

[AutoInject]
public interface ICategoryRepository
{
  Task<Guid?> CreateAsync(DbCategory dbCategory);

  Task<(List<DbCategory>, int totalCount)> FindAsync(FindCategoriesFilter filter, CancellationToken cancellationToken = default);

  Task<DbCategory> GetAsync(Guid id, CancellationToken cancellationToken = default);

  Task<bool> EditAsync(Guid id, Guid modifiedBy, JsonPatchDocument<DbCategory> request, CancellationToken cancellationToken = default);

  Task<bool> UpdateAsync(Guid id, Guid modifiedBy, EditCategoryRequest request, CancellationToken ct = default);

  Task<bool> RemoveAsync(DbCategory category, Guid modifiedBy);

  Task<bool> IsNameExistsAsync(string name, Guid workspaceId, Guid? categoryId = null, CancellationToken cancellationToken = default);
}
