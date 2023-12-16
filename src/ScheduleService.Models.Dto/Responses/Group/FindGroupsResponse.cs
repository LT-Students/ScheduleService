using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;

public class FindGroupsResponse
{
  public List<FindGroupResponse> GetGroupResponses { get; set; }
}
