using JoloLoverServices.WebModels.WalletWebModels;
using JoloLoverServices.Models;

namespace JoloLoverServices.Controllers.Extensions.WalletControllerExtensions;

internal static class WalletWebRequestExtensions
{
    public static Wallet ToRequest(this WalletWebRequest webRequest)
    {
        Wallet result = null;

        if (webRequest != null)
        {
            result = new Wallet
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId,
                Name = webRequest.Name,
                Balance = webRequest.Balance,
                Currency = webRequest.Currency
            };
        }

        return result;
    }
}
