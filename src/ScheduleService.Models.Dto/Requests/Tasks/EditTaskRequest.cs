using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;

public record EditTaskRequest
{
  public Guid TypeId { get; set; } //TaskId
  public string Name { get; set; }
  public string Description { get; set; }
  public int Type { get; set; }
  public Guid WorkspaceId { get; set; }
  public Guid GroupId { get; set; }
}
