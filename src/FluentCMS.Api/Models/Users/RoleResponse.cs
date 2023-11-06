﻿namespace FluentCMS.Api.Models.Users;
public class RoleResponse
{
    public required Guid Id { get; set; }
    public required string CreatedBy { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required string LastUpdatedBy { get; set; }
    public required DateTime LastUpdatedAt { get; set; }

    public required string Name { get; set; }
    public string? Description { get; set; }
    public required bool AutoAssigned { get; set; }

    public Guid? SiteId { get; set; }
}
