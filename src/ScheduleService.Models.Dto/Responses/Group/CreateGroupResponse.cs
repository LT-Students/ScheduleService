using System.Collections.Generic;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;

public class CreateGroupResponse
{
  Guid GroupId { get; set; }

  List<string> Erorrs { get; set; }
}
