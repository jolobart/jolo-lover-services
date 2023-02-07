using JoloLoverServices.Models;
using JoloLoverServices.Validations.WalletSpecifications.UpsertWalletSpecifications;

namespace JoloLoverServices.Validations.WalletSpecifications;

internal class UpsertWalletSpecification : Specification<Wallet>
{
    private static Specification<Wallet> spec = new IdIsNotNullOrEmptySpecification()
        .Or(new UserIdIsNotNullOrEmptySpecification())
        .And(new CurrencyIsNotNullOrEmptySpecification())
        .And(new NameIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(Wallet entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
