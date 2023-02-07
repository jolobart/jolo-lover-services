using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.CategorySpecifications.RemoveCategorySpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<RemoveCategoryRequest>
{
    public override bool IsSatisfiedBy(RemoveCategoryRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}