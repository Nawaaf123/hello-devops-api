using Microsoft.AspNetCore.Mvc;

namespace HelloDevOpsApi.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                status = "Healthy",
                service = "HelloDevOpsApi",
                version = "v1.0",
                environment = "Development",
                timestamp = DateTime.UtcNow
            });
        }

    }
}
