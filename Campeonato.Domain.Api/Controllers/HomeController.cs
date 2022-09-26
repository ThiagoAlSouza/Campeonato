using Microsoft.AspNetCore.Mvc;

namespace Campeonato.Domain.Api.Controllers;

public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("v1")]
    public IActionResult Home()
    {
        return Ok();
    }
}