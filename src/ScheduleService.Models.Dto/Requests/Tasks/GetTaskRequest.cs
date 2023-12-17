using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks
{
  public record GetTaskRequest
  {
    public Guid TaskId { get; set; }
  }
}
