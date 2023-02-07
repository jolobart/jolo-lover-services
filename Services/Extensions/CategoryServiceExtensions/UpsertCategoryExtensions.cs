using JoloLoverServices.Validations.CategorySpecifications;
using JoloLoverServices.Models;

namespace JoloLoverServices.Services.Extension.CategoryServiceExtensions;

internal static class UpsertCategoryExtensions
{
    public static bool IsValid(this Category request, ref ICollection<string> errors)
    {
        var spec = new UpsertCategorySpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}