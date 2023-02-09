using Microsoft.AspNetCore.Mvc;
using JoloLoverServices.WebModels.UserWebModels;
using JoloLoverServices.Controllers.Extensions;
using JoloLoverServices.Controllers.Extensions.AuthControllerExtensions;
using JoloLoverServices.Managers.Interfaces;
using JoloLoverServices.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace JoloLoverServices.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : Controller
{
    private readonly IAuthManager _authManager;
    private readonly IUserService _dataService;

    public AuthController(IAuthManager authManager, IUserService userService)
    {
        _authManager = authManager;
        _dataService = userService;
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("login")]
    public IActionResult PasswordLogin([FromBody] PasswordLoginWebRequest request)
    {
        var response = _authManager.PasswordLogin(request.ToRequest());
        return this.CreateResponse(response);
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("register")]
    public IActionResult Register([FromBody] RegisterWebRequest request)
    {
        var response = _dataService.Register(request.ToRequest());
        return this.CreateResponse(response);
    }

    [Authorize]
    [HttpPost]
    [Route("{id}")]
    public IActionResult GetUserById([FromRoute] int id)
    {
        var response = _dataService.GetUserById(id);
        return this.CreateResponse(response);
    }
}
