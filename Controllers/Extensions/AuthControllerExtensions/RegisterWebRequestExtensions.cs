using JoloLoverServices.WebModels.UserWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.AuthControllerExtensions;

internal static class RegisterWebRequestExtensions
{
    public static RegisterRequest ToRequest(this RegisterWebRequest webRequest)
    {
        RegisterRequest result = null;

        if (webRequest != null)
        {
            result = new RegisterRequest
            {
                FirstName = webRequest.Firstname,
                Lastname = webRequest.Lastname,
                Email = webRequest.Email,
                Password = webRequest.Password
            };
        }

        return result;
    }
}
