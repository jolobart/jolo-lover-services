using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.CategorySpecifications.UpsertCategorySpecifications;

internal class NameIsNotNullOrEmptySpecification : Specification<Category>
{
    public override bool IsSatisfiedBy(Category entity, ref ICollection<string> errors)
    {
        var result = IsNullOrEmptyOrWhiteSpace(entity.Name);

        if (!result)
        {
            errors.Add("Invalid category name");
        }

        return result;
    }

    private bool IsNullOrEmptyOrWhiteSpace(string name)
    {
        return !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name);
    }
}