using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses.GroupUser;

public class FindGroupUserResponse
{
  public Guid GroupId { get; set; }

  public string Error { get; set; }
}
