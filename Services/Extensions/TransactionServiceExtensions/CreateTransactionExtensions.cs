using JoloLoverServices.Validations.TransactionSpecifications;
using JoloLoverServices.Models;

namespace JoloLoverServices.Services.Extension.TransactionServiceExtensions;

internal static class CreateTransactionExtensions
{
    public static bool IsValid(this Transaction request, ref ICollection<string> errors)
    {
        var spec = new CreateTransactionSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
