using JoloLoverServices.WebModels.CategoryWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.CategoryControllerExtensions;

internal static class GetCategoryWebRequestExtensions
{
    public static GetCategoryRequest ToRequest(this GetCategoryWebRequest webRequest)
    {
        GetCategoryRequest result = null;

        if (webRequest != null)
        {
            result = new GetCategoryRequest
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId
            };
        }

        return result;
    }
}
