using FindiJobs.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FindiJobs.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<GetHealth> _logger;
    private readonly IUserService userService;

    public UserController(ILogger<GetHealth> logger, IUserService userService)
    {
        _logger = logger;
        this.userService = userService;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        var result = this.userService.GetUsers();
        return new OkObjectResult(result);
    }
}
