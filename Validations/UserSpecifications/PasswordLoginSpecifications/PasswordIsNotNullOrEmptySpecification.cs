using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.UserSpecifications.PasswordLoginSpecifications;

internal class PasswordIsNotNullOrEmptySpecification : Specification<PasswordLoginRequest>
{
    public override bool IsSatisfiedBy(PasswordLoginRequest entity, ref ICollection<string> errors)
    {
        var result = IsNullOrEmptyOrWhiteSpace(entity.PasswordHash);

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