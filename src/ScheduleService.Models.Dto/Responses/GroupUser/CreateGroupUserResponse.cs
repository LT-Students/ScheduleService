using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses.GroupUser;

public class CreateGroupUserResponse
{
  public Guid UserId { get; set; }

  public List<string> Errors { get; set; }
}
