using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.CategorySpecifications.UpsertCategorySpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<Category>
{
    public override bool IsSatisfiedBy(Category entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}