using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.WalletSpecifications.UpsertWalletSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<Wallet>
{
    public override bool IsSatisfiedBy(Wallet entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}