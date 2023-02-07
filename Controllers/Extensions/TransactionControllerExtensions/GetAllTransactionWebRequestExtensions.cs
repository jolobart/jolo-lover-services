using JoloLoverServices.WebModels.TransactionWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.TransactionControllerExtensions;

internal static class GetAllTransactionWebRequestExtensions
{
    public static GetAllTransactionRequest ToRequest(this GetAllTransactionWebRequest webRequest)
    {
        GetAllTransactionRequest result = null;

        if (webRequest != null)
        {
            result = new GetAllTransactionRequest
            {
                UserId = webRequest.UserId,
                WalletId = webRequest.WalletId
            };
        }

        return result;
    }
}
