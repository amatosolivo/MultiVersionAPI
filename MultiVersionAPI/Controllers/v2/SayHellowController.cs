using Microsoft.AspNetCore.Mvc;

namespace MultiVersionAPI.Controllers.v2;

// api/v1/

[ApiController]
[Route("api/[controller]")] // To work without version
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class SayHellowController : ControllerBase
{
    private readonly ILogger<SayHellowController> _logger;

    public SayHellowController(ILogger<SayHellowController> logger)
    {
        _logger = logger;
    }

    [MapToApiVersion("2.0")]
    [HttpGet]
    public string Get()
    {
        return "Hellow from GET V.2";
    }
}