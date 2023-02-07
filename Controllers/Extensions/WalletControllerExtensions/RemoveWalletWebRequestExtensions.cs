using JoloLoverServices.WebModels.WalletWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.WalletControllerExtensions;

internal static class RemoveWalletWebRequestExtensions
{
    public static RemoveWalletRequest ToRequest(this RemoveWalletWebRequest webRequest)
    {
        RemoveWalletRequest result = null;

        if (webRequest != null)
        {
            result = new RemoveWalletRequest
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId
            };
        }

        return result;
    }
}
