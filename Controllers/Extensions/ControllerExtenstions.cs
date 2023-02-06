using Microsoft.AspNetCore.Mvc;
using JoloLoverServices.Models;

namespace JoloLoverServices.Controllers.Extensions;

public static class ControllerExtensions
{
    public static IActionResult CreateResponse<T>(this Controller controller, ResponseBase<T> response)
    {
        return controller.StatusCode(response.Code, response.ToWebModel());
    }
}