using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.WalletSpecifications;

namespace JoloLoverServices.Services.Extension.WalletServiceExtensions;

internal static class GetWalletByIdExtensions
{
    public static bool IsValid(this GetWalletRequest request, ref ICollection<string> errors)
    {
        var spec = new GetWalletByIdSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
