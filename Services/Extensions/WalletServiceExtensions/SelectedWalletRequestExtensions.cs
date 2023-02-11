using JoloLoverServices.Validations.WalletSpecifications;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Services.Extension.WalletServiceExtensions;

internal static class SelectedWalletRequestExtensions
{
    public static bool IsValid(this SelectedWalletRequest request, ref ICollection<string> errors)
    {
        var spec = new SelectWalletSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
