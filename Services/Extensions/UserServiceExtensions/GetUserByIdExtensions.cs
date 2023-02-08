using JoloLoverServices.Validations.UserSpecifications;

namespace JoloLoverServices.Services.Extension.UserServiceExtensions;

internal static class GetUserByIdExtensions
{
    public static bool IsValid(this int request, ref ICollection<string> errors)
    {
        var spec = new GetUserByIdByIdSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
