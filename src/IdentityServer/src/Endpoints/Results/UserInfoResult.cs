﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using Zen.IdentityServer.Extensions;
using Zen.IdentityServer.Hosting;
using Microsoft.AspNetCore.Http;

namespace Zen.IdentityServer.Endpoints.Results;

internal class UserInfoResult : IEndpointResult
{
    public Dictionary<string, object> Claims;

    public UserInfoResult(Dictionary<string, object> claims)
    {
        Claims = claims;
    }

    public async Task ExecuteAsync(HttpContext context)
    {
        context.Response.SetNoCache();
        await context.Response.WriteJsonAsync(Claims);
    }
}