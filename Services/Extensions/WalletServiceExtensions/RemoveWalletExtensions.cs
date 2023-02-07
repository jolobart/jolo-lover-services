using JoloLoverServices.Validations.WalletSpecifications;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Services.Extension.WalletServiceExtensions;

internal static class RemoveWalletExtensions
{
    public static bool IsValid(this RemoveWalletRequest request, ref ICollection<string> errors)
    {
        var spec = new RemoveWalletSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }

    public static GetWalletRequest ToGetWalletRequest(this RemoveWalletRequest request, int id, int userId)
    {
        GetWalletRequest result = null;

        if (id != null && userId != null)
        {
            result = new GetWalletRequest
            {
                Id = id,
                UserId = userId
            };
        }

        return result;
    }
}
