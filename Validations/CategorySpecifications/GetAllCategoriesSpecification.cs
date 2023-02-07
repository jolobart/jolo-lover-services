using JoloLoverServices.Validations.CategorySpecifications.GetAllCategoriesSpecifications;

namespace JoloLoverServices.Validations.CategorySpecifications;

internal class GetAllCategoriesSpecification : Specification<int>
{
    private static Specification<int> spec = new UserIdIsNotNullOrEmptySpecification();

    public override bool IsSatisfiedBy(int entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
