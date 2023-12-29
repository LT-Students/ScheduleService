using LT.DigitalOffice.Kernel.Extensions;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db;

public class DbTaskMapper
{
  private readonly IHttpContextAccessor _httpContextAccessor;

  public DbTaskMapper(IHttpContextAccessor httpContextAccessor)
  {
    _httpContextAccessor = httpContextAccessor;
  }

  public DbTask Map(CreateTaskRequest request)
  {
    return request is null
      ? null
      : new DbTask
      {
        Id = Guid.NewGuid(),
        Name = request.Name,
        GroupId = request.GroupId,
        WorkspaceId = request.WorkspaceId,
        Description = request.Description,
        Type = (int)request.Type,
        CreatedBy = _httpContextAccessor.HttpContext.GetUserId(),
        CreatedAtUtc = DateTime.UtcNow,
        IsActive = true
      };
  }
}
