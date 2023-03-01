using Microsoft.AspNetCore.Mvc;

namespace stars_api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    public ActionResult Get()
    {
        return Ok("OK");
    }
}
