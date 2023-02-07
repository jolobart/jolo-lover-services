using JoloLoverServices.Validations.CategorySpecifications;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Services.Extension.CategoryServiceExtensions;

internal static class RemoveCategoryExtensions
{
    public static bool IsValid(this RemoveCategoryRequest request, ref ICollection<string> errors)
    {
        var spec = new RemoveCategorySpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }

    public static GetCategoryRequest ToGetCategoryRequest(this RemoveCategoryRequest request, int id, int userId)
    {
        GetCategoryRequest result = null;

        if (id != null && userId != null)
        {
            result = new GetCategoryRequest
            {
                Id = id,
                UserId = userId
            };
        }

        return result;
    }
}
