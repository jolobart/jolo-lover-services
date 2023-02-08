using JoloLoverServices.Models.Request;
using JoloLoverServices.Models.Response;

namespace JoloLoverServices.Managers.Interfaces;

public interface IAuthManager
{
    AuthorizeResponse PasswordLogin(PasswordLoginRequest request);
}
