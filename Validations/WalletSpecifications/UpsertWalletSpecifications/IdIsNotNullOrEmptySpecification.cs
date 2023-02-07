using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.WalletSpecifications.UpsertWalletSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<Wallet>
{
    public override bool IsSatisfiedBy(Wallet entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}