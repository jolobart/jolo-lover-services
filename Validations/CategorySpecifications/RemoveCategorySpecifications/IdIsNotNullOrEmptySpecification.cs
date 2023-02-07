using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.CategorySpecifications.RemoveCategorySpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<RemoveCategoryRequest>
{
    public override bool IsSatisfiedBy(RemoveCategoryRequest entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid category Id");
        }

        return result;
    }
}