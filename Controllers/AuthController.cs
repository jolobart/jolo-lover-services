using Microsoft.AspNetCore.Mvc;
using JoloLoverServices.WebModels.UserWebModels;
using JoloLoverServices.Controllers.Extensions;
using JoloLoverServices.Controllers.Extensions.AuthControllerExtensions;
using JoloLoverServices.Managers.Interfaces;

namespace JoloLoverServices.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : Controller
{
    private readonly IAuthManager _authManager;

    public AuthController(IAuthManager authManager)
    {
        _authManager = authManager;
    }

    [HttpPost]
    [Route("login")]
    public IActionResult PasswordLogin([FromBody] PasswordLoginWebRequest request)
    {
        var response = _authManager.PasswordLogin(request.ToRequest());
        return this.CreateResponse(response);
    }
}
