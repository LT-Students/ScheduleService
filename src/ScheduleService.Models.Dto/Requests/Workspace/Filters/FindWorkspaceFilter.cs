using LT.DigitalOffice.Kernel.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;

public record FindWorkspaceFilter : BaseFindFilter
{
  [FromQuery(Name = "isAscendingSort")]
  public bool? IsAscendingSort { get; set; }

  [FromQuery(Name = "nameIncludeSubstring")]
  public string nameIncludeSubstring { get; set; }

  [FromQuery(Name = "IsActive")]
  public bool? IsActive { get; set; }
}
