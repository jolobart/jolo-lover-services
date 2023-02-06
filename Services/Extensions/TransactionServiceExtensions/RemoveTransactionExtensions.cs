using JoloLoverServices.Validations.TransactionSpecifications;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Services.Extension.TransactionServiceExtensions;

internal static class RemoveTransactionExtensions
{
    public static bool IsValid(this RemoveTransactionRequest request, ref ICollection<string> errors)
    {
        var spec = new RemoveTransactionSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }

    public static GetTransactionRequest ToGetTransactionRequest(this RemoveTransactionRequest request, int id, int userId, int walletId)
    {
        GetTransactionRequest result = null;

        if (id != null && userId != null && walletId != null)
        {
            result = new GetTransactionRequest
            {
                Id = id,
                UserId = userId,
                WalletId = walletId
            };
        }

        return result;
    }
}
