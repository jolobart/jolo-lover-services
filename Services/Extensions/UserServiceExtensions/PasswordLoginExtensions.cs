using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.UserSpecifications;

namespace JoloLoverServices.Services.Extension.UserServiceExtensions;

internal static class PasswordLoginExtensions
{
    public static bool IsValid(this PasswordLoginRequest request, ref ICollection<string> errors)
    {
        var spec = new PasswordLoginSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
