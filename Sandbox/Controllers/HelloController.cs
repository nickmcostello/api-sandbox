using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello.";
    }
}
