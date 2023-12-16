using System.Collections.Generic;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Groups;

public class CreateGroupsResponse
{
  Guid GroupId { get; set; }

  List<string> Erorrs { get; set; }
}
