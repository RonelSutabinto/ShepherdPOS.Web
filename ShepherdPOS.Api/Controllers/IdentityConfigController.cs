﻿using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Mvc;

namespace ShepherdPOS.Api.Controllers
{
    public class IdentityConfigController : Controller
    {
        readonly ILogger<IdentityConfigController> Logger;

        public IdentityConfigController(IClientRequestParametersProvider clientRequestParametersProvider, ILogger<IdentityConfigController> logger)
        {
            ClientRequestParametersProvider = clientRequestParametersProvider;
            Logger = logger;
        }

        public IClientRequestParametersProvider ClientRequestParametersProvider { get; }

        [HttpGet("_configuration/{clientId}")]
        public IActionResult GetClientRequestParameters([FromRoute] string clientId)
        {
            var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return Ok(parameters);
        }
    }
}

