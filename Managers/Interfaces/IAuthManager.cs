using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Models.Response;

namespace JoloLoverServices.Managers.Interfaces;

public interface IAuthManager
{
    ResponseBase<AuthorizeResponse> PasswordLogin(PasswordLoginRequest request);
}
