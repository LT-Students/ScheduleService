using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

public record WorkspaceResponse
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public bool IsActive { get; set; }
}
