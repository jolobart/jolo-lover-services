using JoloLoverServices.Validations.TransactionSpecifications;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Services.Extension.TransactionServiceExtensions;

internal static class GetTransactionRequestExtentions
{
    public static bool IsValid(this GetTransactionRequest request, ref ICollection<string> errors)
    {
        var spec = new GetTransactionSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
