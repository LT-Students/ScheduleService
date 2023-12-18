using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

public class GetTaskResponse
{
  public string Name { get; set; }
  public string Description { get; set; }
  public int Type { get; set; }
  public Guid WorkspaceId { get; set; }
  public Guid GroupId { get; set; }
  public List<string> Errors { get; set; }
}
