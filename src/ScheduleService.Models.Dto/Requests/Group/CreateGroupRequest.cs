using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;

public class CreateGroupRequest
{
  public Guid WorkspaceId { get; set; }
  public string Name { get; set; }
}
