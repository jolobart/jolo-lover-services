using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Interfaces;

public interface IUserService
{
    ResponseBase<User> PasswordLogin(PasswordLoginRequest request);
}
