using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Groups;
using LT.DigitalOffice.ScheduleService.Validation.Groups.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Validation.Groups;
public class CreateGroupsRequestValidator :AbstractValidator<CreateGroupsRequest>, ICreateGroupsRequestValidator
{
  public CreateGroupsRequestValidator() { }
}
