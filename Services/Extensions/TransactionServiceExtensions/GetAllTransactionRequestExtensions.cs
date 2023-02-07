using JoloLoverServices.Validations.TransactionSpecifications;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Services.Extension.TransactionServiceExtensions;

internal static class GetAllTransactionRequestExtensions
{
    public static bool IsValid(this GetAllTransactionRequest request, ref ICollection<string> errors)
    {
        var spec = new GetAllTransactionSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
