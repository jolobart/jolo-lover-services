using JoloLoverServices.WebModels.TransactionWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.TransactionControllerExtensions;

internal static class RemoveTransactionWebRequestExtensions
{
    public static RemoveTransactionRequest ToRequest(this RemoveTransactionWebRequest webRequest)
    {
        RemoveTransactionRequest result = null;

        if (webRequest != null)
        {
            result = new RemoveTransactionRequest
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId,
                WalletId = webRequest.WalletId
            };
        }

        return result;
    }
}
