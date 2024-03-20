using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models;

public class CategoryResponseMapper : ICategoryResponseMapper
{
  public CategoryResponse Map(DbCategory dbCategory)
  {
    return new CategoryResponse
    {
      Id = dbCategory.Id,
      Name = dbCategory.Name,
      Color = dbCategory.Color,
      WorkspaceId = dbCategory.WorkspaceId,
      IsActive = dbCategory.IsActive
    };
  }
}
