using Microsoft.AspNetCore.Mvc;

namespace Campeonato.Domain.Api.Controllers.Home;

public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("v1")]
    public IActionResult Home()
    {
        return Ok();
    }
}