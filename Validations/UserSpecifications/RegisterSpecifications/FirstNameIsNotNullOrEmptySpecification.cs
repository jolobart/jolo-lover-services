using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.UserSpecifications.RegisterSpecifications;

internal class FirstNameIsNotNullOrEmptySpecification : Specification<RegisterRequest>
{
    public override bool IsSatisfiedBy(RegisterRequest entity, ref ICollection<string> errors)
    {
        var result = IsNullOrEmptyOrWhiteSpace(entity.FirstName);

        if (!result)
        {
            errors.Add("Invalid first name");
        }

        return result;
    }

    private bool IsNullOrEmptyOrWhiteSpace(string name)
    {
        return !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name);
    }
}