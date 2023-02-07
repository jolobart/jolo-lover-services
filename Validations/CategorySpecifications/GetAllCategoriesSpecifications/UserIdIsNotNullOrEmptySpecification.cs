namespace JoloLoverServices.Validations.CategorySpecifications.GetAllCategoriesSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<int>
{
    public override bool IsSatisfiedBy(int entity, ref ICollection<string> errors)
    {
        var result = entity != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}