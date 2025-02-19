﻿namespace FluentCMS.Repositories.LiteDb;

public class ApiTokenRepository(
    ILiteDBContext liteDbContext,
    IAuthContext authContext) :
    AuditableEntityRepository<ApiToken>(liteDbContext, authContext),
    IApiTokenRepository
{

}
