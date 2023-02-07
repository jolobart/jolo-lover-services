using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.CategorySpecifications.UpsertCategorySpecifications;

internal class TypeIsNotNullOrEmptySpecification : Specification<Category>
{
    public override bool IsSatisfiedBy(Category entity, ref ICollection<string> errors)
    {
        var result = IsValidType(entity.Type);

        if (!result)
        {
            errors.Add("Invalid category type");
        }

        return result;
    }

    private bool IsValidType(string type)
    {
        return !string.IsNullOrEmpty(type) && type == "expense" || type == "income";
    }
}