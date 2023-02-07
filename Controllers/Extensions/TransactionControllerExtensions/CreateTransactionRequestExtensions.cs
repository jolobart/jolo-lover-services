using JoloLoverServices.WebModels.TransactionWebModels;
using JoloLoverServices.Models;

namespace JoloLoverServices.Controllers.Extensions.TransactionControllerExtensions;

internal static class CreateTransactionRequestExtensions
{
    public static Transaction ToRequest(this CreateTransactionWebRequest webRequest)
    {
        Transaction result = null;

        if (webRequest != null)
        {
            result = new Transaction
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId,
                WalletId = webRequest.WalletId,
                CategoryId = webRequest.CategoryId,
                Amount = webRequest.Amount,
                Notes = webRequest.Notes,
                DateTime = new DateTime(webRequest.DateTime)
            };
        }

        return result;
    }
}
