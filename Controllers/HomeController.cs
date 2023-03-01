using Microsoft.AspNetCore.Mvc;

namespace stars_api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [Route("/star-trek/characters/{name}")]
    public ActionResult Get(string name)
    {
        return Ok(name);
    }
}
