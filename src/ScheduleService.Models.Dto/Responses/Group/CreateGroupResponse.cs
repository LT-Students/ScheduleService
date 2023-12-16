using System.Collections.Generic;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Groups;

public class CreateGroupResponse
{
  Guid GroupId { get; set; }

  List<string> Erorrs { get; set; }
}
