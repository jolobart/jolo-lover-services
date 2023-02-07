using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.CategorySpecifications.UpsertCategorySpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<Category>
{
    public override bool IsSatisfiedBy(Category entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid category Id");
        }

        return result;
    }
}