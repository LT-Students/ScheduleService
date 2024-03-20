using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;
using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

public record CategoryResponse
{
  /// <summary>
  /// Category identifier.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Category's workspace identifier.
  /// </summary>
  public Guid WorkspaceId { get; set; }

  /// <summary>
  /// Category name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Category color.
  /// </summary>
  public CategoryColor Color { get; set; }

  /// <summary>
  /// When this value is 'true' the category is active, when it's 'false' the category is inactive.
  /// </summary>
  public bool IsActive { get; set; }
}
