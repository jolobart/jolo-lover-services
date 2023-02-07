using JoloLoverServices.Models;
using JoloLoverServices.Validations.CategorySpecifications.UpsertCategorySpecifications;

namespace JoloLoverServices.Validations.CategorySpecifications;

internal class UpsertCategorySpecification : Specification<Category>
{
    private static Specification<Category> spec = new IdIsNotNullOrEmptySpecification()
        .Or(new UserIdIsNotNullOrEmptySpecification())
        .And(new NameIsNotNullOrEmptySpecification())
        .And(new TypeIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(Category entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
