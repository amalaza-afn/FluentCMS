﻿namespace FluentCMS.Repositories.LiteDb;

public class PageRepository : SiteAssociatedRepository<Page>, IPageRepository
{
    public PageRepository(ILiteDBContext liteDbContext, IAuthContext authContext) : base(liteDbContext, authContext)
    {
    }
}
