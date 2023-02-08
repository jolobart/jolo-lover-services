using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.UserSpecifications.RegisterSpecifications;

internal class PasswordIsNotNullOrEmptySpecification : Specification<RegisterRequest>
{
    public override bool IsSatisfiedBy(RegisterRequest entity, ref ICollection<string> errors)
    {
        var result = IsNullOrEmptyOrWhiteSpace(entity.Password);

        if (!result)
        {
            errors.Add("Invalid password");
        }

        return result;
    }

    private bool IsNullOrEmptyOrWhiteSpace(string passwordHash)
    {
        return !string.IsNullOrEmpty(passwordHash) && !string.IsNullOrWhiteSpace(passwordHash);
    }
}