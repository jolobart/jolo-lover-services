using JoloLoverServices.WebModels.TransactionWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.TransactionControllerExtensions;

internal static class GetTransactionWebRequestExtensions
{
    public static GetTransactionRequest ToRequest(this GetTransactionWebRequest webRequest)
    {
        GetTransactionRequest result = null;

        if (webRequest != null)
        {
            result = new GetTransactionRequest
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId,
                WalletId = webRequest.WalletId
            };
        }

        return result;
    }
}
