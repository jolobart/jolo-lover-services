using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.CategorySpecifications.GetCategoryByIdSpecifications;

namespace JoloLoverServices.Validations.CategorySpecifications;

internal class GetCategoryByIdSpecification : Specification<GetCategoryRequest>
{
    private static Specification<GetCategoryRequest> spec = new IdIsNotNullOrEmptySpecification()
        .And(new UserIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(GetCategoryRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
