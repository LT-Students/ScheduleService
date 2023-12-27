using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;

public class EditGroupUserRequest
{
  public Guid GroupId { get; set; }

  public Guid UserId { get; set; }
}
