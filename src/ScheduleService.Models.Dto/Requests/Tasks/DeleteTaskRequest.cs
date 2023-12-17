using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks
{
  public record DeleteTaskRequest
  {
    public Guid TaskId { get; set; }
  }
}
