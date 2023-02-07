using JoloLoverServices.Validations.WalletSpecifications;
using JoloLoverServices.Models;

namespace JoloLoverServices.Services.Extension.WalletServiceExtensions;

internal static class UpsertWalletExtensions
{
    public static bool IsValid(this Wallet request, ref ICollection<string> errors)
    {
        var spec = new UpsertWalletSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}