using JoloLoverServices.WebModels.WalletWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.WalletControllerExtensions;

internal static class SelectedWalletRequestExtensions
{
    public static SelectedWalletRequest ToRequest(this SelectedWalletWebRequest webRequest)
    {
        SelectedWalletRequest result = null;

        if (webRequest != null)
        {
            result = new SelectedWalletRequest
            {
                WalletId = webRequest.WalletId,
                UserId = webRequest.UserId
            };
        }

        return result;
    }
}
