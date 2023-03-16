//================================================================================================================================
//This part of code uses ILogger to capture identity and provide a minimum log level for a specific http response.================
//================================================================================================================================
//Try this link for more detailshttps://www.c-sharpcorner.com/article/logging-framework-in-asp-net-core-2-0/======================
//================================================================================================================================

using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
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
            try
            {
                var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
                return Ok(parameters);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

