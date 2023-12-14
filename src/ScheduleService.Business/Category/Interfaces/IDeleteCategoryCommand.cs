﻿using LT.DigitalOffice.Kernel.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;

[AutoInject]
public interface IDeleteCategoryCommand
{
  Task<IActionResult> ExecuteAsync(Guid id);
}
