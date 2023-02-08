using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.UserSpecifications.RegisterSpecifications;

namespace JoloLoverServices.Validations.UserSpecifications;

internal class RegisterSpecification : Specification<RegisterRequest>
{
    private static Specification<RegisterRequest> spec = new EmailIsValidNotNullOrEmptySpecification()
        .And(new PasswordIsNotNullOrEmptySpecification())
        .And(new FirstNameIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(RegisterRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
