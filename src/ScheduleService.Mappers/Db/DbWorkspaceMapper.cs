﻿using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db;

public class DbWorkspaceMapper : IDbWorkspaceMapper
{
  public DbWorkspace Map(CreateWorkspaceRequest request, Guid userId)
  {
    return request is null
      ? null
      : new DbWorkspace
      {
        Id = Guid.NewGuid(),
        Name = request.Name,
        CreatedBy = userId,
        CreatedAtUtc = DateTime.UtcNow,
        ModifiedBy = userId,
        ModifiedAtUtc = DateTime.UtcNow,
        IsActive = true
      };
  }
}
