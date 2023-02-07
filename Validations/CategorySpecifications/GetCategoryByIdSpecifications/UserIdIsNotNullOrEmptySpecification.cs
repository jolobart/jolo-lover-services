using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.CategorySpecifications.GetCategoryByIdSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<GetCategoryRequest>
{
    public override bool IsSatisfiedBy(GetCategoryRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}