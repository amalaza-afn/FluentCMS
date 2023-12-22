﻿using AutoMapper;
using FluentCMS.Entities;
using FluentCMS.Services;
using FluentCMS.Web.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentCMS.Web.Api.Controllers;

public class GlobalSettingsController(IGlobalSettingsService service, IMapper mapper) : BaseGlobalController
{

    [HttpPut]
    public async Task<IApiResult<GlobalSettings>> Update(GlobalSettingsUpdateRequest request, CancellationToken cancellationToken = default)
    {
        var settings = mapper.Map<GlobalSettings>(request);

        var updated = await service.Update(settings, cancellationToken);

        return Ok(updated);
    }

    [HttpGet]
    public async Task<IApiResult<GlobalSettings>> Get(CancellationToken cancellationToken = default)
    {
        var systemSettings = await service.Get(cancellationToken) ??
            throw new AppException(ExceptionCodes.GlobalSettingsNotFound);

        return Ok(systemSettings);
    }
}
