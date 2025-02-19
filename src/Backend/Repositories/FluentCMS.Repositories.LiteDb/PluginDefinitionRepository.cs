﻿namespace FluentCMS.Repositories.LiteDb;

public class PluginDefinitionRepository(ILiteDBContext liteDbContext, IAuthContext authContext)
    : AuditableEntityRepository<PluginDefinition>(liteDbContext, authContext), IPluginDefinitionRepository;
