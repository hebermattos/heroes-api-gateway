using Microsoft.AspNetCore.Mvc;

namespace heroes_api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{  
    public string Get()
    {
       return "OK";
    }
}
