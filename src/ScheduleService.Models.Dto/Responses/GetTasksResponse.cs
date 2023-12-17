using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses
{
  public class GetTasksResponse
  {
    public List<GetTaskResponse> GetTasksResponses { get; set; }
    public List<string> Errors { get; set; }
  }
}
