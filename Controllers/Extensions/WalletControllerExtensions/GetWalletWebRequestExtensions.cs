using JoloLoverServices.WebModels.WalletWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.WalletControllerExtensions;

internal static class GetWalletWebRequestExtensions
{
    public static GetWalletRequest ToRequest(this GetWalletWebRequest webRequest)
    {
        GetWalletRequest result = null;

        if (webRequest != null)
        {
            result = new GetWalletRequest
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId
            };
        }

        return result;
    }
}
