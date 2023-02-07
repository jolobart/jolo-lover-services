using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.WalletSpecifications.GetWalletByIdSpecifications;

namespace JoloLoverServices.Validations.WalletSpecifications;

internal class GetWalletByIdSpecification : Specification<GetWalletRequest>
{
    private static Specification<GetWalletRequest> spec = new IdIsNotNullOrEmptySpecification()
        .And(new UserIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(GetWalletRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
