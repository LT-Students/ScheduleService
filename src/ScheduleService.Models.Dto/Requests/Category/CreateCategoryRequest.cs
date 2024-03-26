using System;
using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;

public class CreateCategoryRequest
{
  public string Name { get; set; }

  public CategoryColor Color { get; set; }

  public Guid WorkspaceId { get; set; }
}
