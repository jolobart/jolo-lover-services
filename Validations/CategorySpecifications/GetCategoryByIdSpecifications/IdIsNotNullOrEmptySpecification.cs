using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.CategorySpecifications.GetCategoryByIdSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<GetCategoryRequest>
{
    public override bool IsSatisfiedBy(GetCategoryRequest entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid category Id");
        }

        return result;
    }
}