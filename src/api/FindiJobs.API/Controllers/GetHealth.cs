using Microsoft.AspNetCore.Mvc;
using FindiJobs.Core;
using FindiJobs.Models;
using FindiJobs.Core.Interfaces;

namespace FindiJobs.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GetHealth : ControllerBase
{
    private readonly ILogger<GetHealth> _logger;
    private readonly IHealthService healthService;

    public GetHealth(ILogger<GetHealth> logger, IHealthService healthService)
    {
        _logger = logger;
        this.healthService = healthService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = this.healthService.GetHealth();
        return new OkObjectResult(result);
    }
}
