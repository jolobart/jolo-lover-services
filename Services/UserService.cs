using JoloLoverServices.Interfaces;
using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Services.Extension.UserServiceExtensions;
using JoloLoverServices.Data.Interfaces;
using System.Net;

namespace JoloLoverServices.Services;

public class UserService : IUserService
{
    private readonly IUserSqlDataGateway _dataGateway;

    public UserService(IUserSqlDataGateway dataGateway)
    {
        _dataGateway = dataGateway;
    }

    public ResponseBase<User> GetUserById(int id)
    {
        var response = new ResponseBase<User>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (id.IsValid(ref errors))
            {
                var user = _dataGateway.FindById(id);
                return response.AsData(user);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<User> PasswordLogin(PasswordLoginRequest request)
    {
        var response = new ResponseBase<User>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var user = _dataGateway.GetUserByEmail(request.Email);

                if (user != null && IsPasswordValid(user.PasswordHash, request.PasswordHash))
                {
                    return response.AsData(user);
                }

                errors.Add("invalid password");
                return response.AsInvalidRequestError(errors);
            }

            errors.Add("no user found associated with the email address");
            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<User> Register(RegisterRequest request)
    {
        var response = new ResponseBase<User>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var user = _dataGateway.Save(request.ToUserRequest());
                return response.AsData(user);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    private bool IsPasswordValid(string hashPassword, string loginPassword)
    {
        return BCrypt.Net.BCrypt.Verify(loginPassword, hashPassword);
    }
}