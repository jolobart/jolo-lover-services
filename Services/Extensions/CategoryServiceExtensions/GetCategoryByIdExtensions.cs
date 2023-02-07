using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.CategorySpecifications;

namespace JoloLoverServices.Services.Extension.CategoryServiceExtensions;

internal static class GetCategoryByIdExtensions
{
    public static bool IsValid(this GetCategoryRequest request, ref ICollection<string> errors)
    {
        var spec = new GetCategoryByIdSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
