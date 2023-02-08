using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.UserSpecifications;

namespace JoloLoverServices.Services.Extension.UserServiceExtensions;

internal static class RegisterRequestExtensions
{
    public static bool IsValid(this RegisterRequest request, ref ICollection<string> errors)
    {
        var spec = new RegisterSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }

    public static User ToUserRequest(this RegisterRequest request)
    {
        User result = null;

        if (request != null)
        {
            result = new User
            {
                Name = request.FirstName + " " + request.Lastname,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
            };
        }

        return result;
    }
}
