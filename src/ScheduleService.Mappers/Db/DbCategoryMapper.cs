using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db;

public class DbCategoryMapper : IDbCategoryMapper
{
  public DbCategory Map(CreateCategoryRequest request, Guid userId)
  {
    return new DbCategory
    {
      Id = Guid.NewGuid(),
      Name = request.Name,
      Color = request.Color,
      WorkspaceId = request.WorkspaceId,
      CreatedBy = userId,
      CreatedAtUtc = DateTime.UtcNow,
      IsActive = true
    };
  }
}
