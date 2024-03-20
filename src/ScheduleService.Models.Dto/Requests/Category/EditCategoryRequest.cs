using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;

public class EditCategoryRequest
{
  public string Name { get; set; }

  public CategoryColor Color { get; set; }

  public bool IsActive { get; set; }
}
