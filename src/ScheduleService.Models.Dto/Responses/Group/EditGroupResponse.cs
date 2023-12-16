using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Groups;

public class EditGroupResponse
{
  public Guid GroupId { get; set; }

  public List<string> Errors { get; set; }
}
