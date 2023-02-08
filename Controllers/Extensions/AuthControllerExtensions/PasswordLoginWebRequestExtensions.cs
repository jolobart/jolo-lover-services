using JoloLoverServices.WebModels.UserWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.AuthControllerExtensions;

internal static class PasswordLoginWebRequestExtensions
{
    public static PasswordLoginRequest ToRequest(this PasswordLoginWebRequest webRequest)
    {
        PasswordLoginRequest result = null;

        if (webRequest != null)
        {
            result = new PasswordLoginRequest
            {
                Email = webRequest.Email,
                PasswordHash = webRequest.Password
            };
        }

        return result;
    }
}
