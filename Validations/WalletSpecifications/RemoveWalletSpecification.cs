using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.WalletSpecifications.RemoveWalletSpecifications;

namespace JoloLoverServices.Validations.WalletSpecifications;

internal class RemoveWalletSpecification : Specification<RemoveWalletRequest>
{
    private static Specification<RemoveWalletRequest> spec = new IdIsNotNullOrEmptySpecification()
        .And(new UserIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(RemoveWalletRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
