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
                service = "HelloDevOps API Service",
                version = "v1.1",
                environment = "Development",
                build = "feature-branch",
                timestamp = DateTime.UtcNow
            });

        }

    }
}
