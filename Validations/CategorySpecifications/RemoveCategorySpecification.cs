using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.CategorySpecifications.RemoveCategorySpecifications;

namespace JoloLoverServices.Validations.CategorySpecifications;

internal class RemoveCategorySpecification : Specification<RemoveCategoryRequest>
{
    private static Specification<RemoveCategoryRequest> spec = new IdIsNotNullOrEmptySpecification()
        .And(new UserIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(RemoveCategoryRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
