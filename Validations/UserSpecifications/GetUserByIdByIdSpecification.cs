namespace JoloLoverServices.Validations.UserSpecifications;

internal class GetUserByIdByIdSpecification : Specification<int>
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