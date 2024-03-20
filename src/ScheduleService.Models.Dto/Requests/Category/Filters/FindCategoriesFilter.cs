using LT.DigitalOffice.Kernel.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;

public record FindCategoriesFilter : BaseFindFilter
{
  [FromQuery(Name = "IsActive")]
  public bool? IsActive { get; set; }

  [FromQuery(Name = "isAscendingSort")]
  public bool? IsAscendingSort { get; set; }

  [FromQuery(Name = "nameIncludeSubstring")]
  public string NameIncludeSubstring { get; set; }
}
