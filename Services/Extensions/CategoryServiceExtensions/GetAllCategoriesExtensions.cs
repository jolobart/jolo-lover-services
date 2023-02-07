using JoloLoverServices.Validations.CategorySpecifications;

namespace JoloLoverServices.Services.Extension.CategoryServiceExtensions;

internal static class GetAllCategoriesExtensions
{
    public static bool IsValid(this int request, ref ICollection<string> errors)
    {
        var spec = new GetAllCategoriesSpecification();
        var result = spec.IsSatisfiedBy(request, ref errors);

        return result;
    }
}
