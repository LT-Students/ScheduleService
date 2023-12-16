using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Controllers;

[Route("[controller]")]
[ApiController]
public class GroupsController
{
  [HttpPost("create")]
  public async Task<IActionResult> CreateAsync(
    [FromServices] ICreate)
  {

  }
}
