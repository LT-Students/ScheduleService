using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Models;

public class GroupResponse
{
  public Guid Id { get; set; }
  public Guid WorkspaceId { get; set; }
  public string Name { get; set; }
}
