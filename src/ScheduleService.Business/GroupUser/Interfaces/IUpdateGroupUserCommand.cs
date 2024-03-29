﻿using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;

[AutoInject]
public interface IUpdateGroupUserCommand
{
  Task<OperationResultResponse<bool>> ExecuteAsync(EditGroupUserRequest request, Guid id);
}
