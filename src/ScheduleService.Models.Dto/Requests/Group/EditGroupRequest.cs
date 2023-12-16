using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;

public class EditGroupRequest
{
  public Guid GroupId { get; set; }

  public string Title { get; set; }
}
