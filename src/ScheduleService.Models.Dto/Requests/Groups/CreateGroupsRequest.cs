using System.ComponentModel.DataAnnotations;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Groups;

public class CreateGroupsRequest
{
  [Required]
  string Title { get; set; }
}
