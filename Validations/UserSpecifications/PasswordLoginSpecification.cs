using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.UserSpecifications.PasswordLoginSpecifications;

namespace JoloLoverServices.Validations.UserSpecifications;

internal class PasswordLoginSpecification : Specification<PasswordLoginRequest>
{
    private static Specification<PasswordLoginRequest> spec = new EmailIsValidNotNullOrEmptySpecification()
        .And(new PasswordIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(PasswordLoginRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
