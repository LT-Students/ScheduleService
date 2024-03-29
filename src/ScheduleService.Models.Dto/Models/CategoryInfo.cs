﻿using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Models;

public class CategoryInfo
{
  public Guid Id { get; set; }
  public Guid WorkspaceId { get; set; }
  public string Name { get; set; }
  public string Color { get; set; }
  public bool IsActive { get; set; }
}
