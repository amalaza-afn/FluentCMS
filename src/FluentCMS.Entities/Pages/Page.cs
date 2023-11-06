﻿namespace FluentCMS.Entities.Pages;

public class Page : AuditEntity
{
    public Guid SiteId { get; set; }
    public required string Title { get; set; }
    public Guid? ParentId { get; set; }
    public int Order { get; set; }
    public required string Path { get; set; }
}
