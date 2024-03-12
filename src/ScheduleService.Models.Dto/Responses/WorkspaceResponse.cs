using System;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

public record WorkspaceResponse
{
  /// <summary>
  /// Workspace identifier.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Workspace name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// When this value is 'true' the workspace is active, when it's 'false' the workspace is inactive.
  /// </summary>
  public bool IsActive { get; set; }
}
