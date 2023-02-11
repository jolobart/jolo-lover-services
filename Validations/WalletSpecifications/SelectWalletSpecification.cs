using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.WalletSpecifications.SelectWalletSpecifications;

namespace JoloLoverServices.Validations.WalletSpecifications;

internal class SelectWalletSpecification : Specification<SelectedWalletRequest>
{
    private static Specification<SelectedWalletRequest> spec = new IdIsNotNullOrEmptySpecification()
        .And(new UserIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(SelectedWalletRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
