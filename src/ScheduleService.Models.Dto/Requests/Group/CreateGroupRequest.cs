using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;

public class CreateGroupRequest
{
  public Guid WorkspaceId { get; set; }
  public string Name { get; set; }
  public List<Guid> UsersId { get; set; }
}
