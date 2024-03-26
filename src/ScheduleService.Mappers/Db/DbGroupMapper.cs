using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using Microsoft.AspNetCore.Http;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db;

public class DbGroupMapper : IDbGroupMapper
{
  private readonly IHttpContextAccessor _httpContextAccessor;

  public DbGroupMapper(IHttpContextAccessor httpContextAccessor)
  {
    _httpContextAccessor = httpContextAccessor;
  }

  public DbGroup Map(CreateGroupRequest request, Guid userId)
  {
    return request is null
      ? null
      : new DbGroup
      {
        Id = Guid.NewGuid(),
        Name = request.Name,
        WorkspaceId = request.WorkspaceId,
        CreatedBy = userId,
        CreatedAtUtc = DateTime.UtcNow,
        IsActive = true
      };
  }
}
