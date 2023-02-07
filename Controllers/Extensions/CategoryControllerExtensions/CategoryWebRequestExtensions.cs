using JoloLoverServices.WebModels.CategoryWebModels;
using JoloLoverServices.Models;

namespace JoloLoverServices.Controllers.Extensions.CategoryControllerExtensions;

internal static class CategoryWebRequestExtensions
{
    public static Category ToRequest(this CategoryWebRequest webRequest)
    {
        Category result = null;

        if (webRequest != null)
        {
            result = new Category
            {
                Id = webRequest.Id,
                UserId = webRequest.UserId,
                Name = webRequest.Name,
                Type = webRequest.Type 
            };
        }

        return result;
    }
}
