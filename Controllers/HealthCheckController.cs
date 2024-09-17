using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("health")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHealthStatus()
    {
        return Ok("Healthy");
    }
}
