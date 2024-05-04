using FindiJobs.Core.Interfaces;
using FindiJobs.Exception;
using FindiJobs.Models;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

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
    [Route("getUsers")]
    public IActionResult GetUsers()
    {
        var result = this.userService.GetUsers();
        return new OkObjectResult(result);
    }

    [HttpGet]
    [Route("getUser")]
    public ActionResult<User> GetUserById(int id)
    {
        var result = this.userService.GetUser(id);
        if(result == null)
        {
            return NotFound("Invalid Id");
        }
        return new OkObjectResult(result);
    }

    [HttpPost]
    [Route("postUser")]
    public ActionResult<User> PostUser(User user)
    {
        try
        {
            var result = this.userService.PostUser(user);
            return new OkObjectResult(result);
        }
        catch (ValidationException exVal)
        {
            var errorException = new FindiJobsExceptions(FindiJobsErrors.BadRequest, exVal);
            return errorException.Error;
        }
        catch (FindiJobsExceptions e)
        {
            return e.Error;
        }
        catch (System.Exception e)
        {
            var errorException = new FindiJobsExceptions(FindiJobsErrors.InternalServerError, e);
            return errorException.Error;
        }

    }

    [HttpPut]
    [Route("updateUser")]
    public ActionResult<User> UpdateUser(int id, User userUpdatedData)
    {
        var result = this.userService.UpdateUser(id, userUpdatedData);
        if (result == null)
        {
            return NotFound("Invalid Id");
        }
        return new OkObjectResult(result);
    }

    [HttpDelete]
    [Route("deleteUser")]
    public ActionResult DeleteUser(int id)
    {
        this.userService.RemoveUser(id);
        return new OkObjectResult(true);
    }
}
