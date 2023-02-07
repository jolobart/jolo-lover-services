using JoloLoverServices.WebModels.CategoryWebModels;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Controllers.Extensions.CategoryControllerExtensions;

internal static class RemoveCategoryWebRequestExtensions
{
    public static RemoveCategoryRequest ToRequest(this RemoveCategoryWebRequest webRequest)
    {
        RemoveCategoryRequest result = null;

        if (webRequest != null)
        {
            result = new RemoveCategoryRequest
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId
            };
        }

        return result;
    }
}
