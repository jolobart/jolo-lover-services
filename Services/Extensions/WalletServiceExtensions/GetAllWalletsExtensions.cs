using JoloLoverServices.Validations.WalletSpecifications;

namespace JoloLoverServices.Services.Extension.WalletServiceExtensions;

internal static class GetAllWalletsExtensions
{
    public static bool IsValid(this int request, ref ICollection<string> errors)
    {
        var spec = new GetAllWalletsSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
