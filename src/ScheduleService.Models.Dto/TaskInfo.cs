using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto
{
  public class TaskInfo
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public TypeOfTask Type { get; set; }

    public Guid WorkspaceId { get; set; }

    public Guid GroupId { get; set; }
  }
}
