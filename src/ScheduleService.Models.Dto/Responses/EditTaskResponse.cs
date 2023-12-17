using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses
{
  public class EditTaskResponse
  {
    public Guid TaskId { get; set; }
    public List<string> Errors { get; set; }
  }
}

