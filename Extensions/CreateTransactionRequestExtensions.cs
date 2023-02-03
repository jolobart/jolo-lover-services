using JoloLoverServices.WebModels;
using JoloLoverServices.Models;

namespace JoloLoverServices.Extension
{
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
                    DateTime = webRequest.DateTime
                };
            }

            return result;
        }
    }
}