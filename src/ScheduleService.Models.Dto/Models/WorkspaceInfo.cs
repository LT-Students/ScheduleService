using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Models;

public class WorkspaceInfo
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public bool IsActive { get; set; }
}
