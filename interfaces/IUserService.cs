using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Interfaces;

public interface IUserService
{
    ResponseBase<User> PasswordLogin(PasswordLoginRequest request);
    ResponseBase<User> Register(RegisterRequest request);
    ResponseBase<User> GetUserById(int id);
}
