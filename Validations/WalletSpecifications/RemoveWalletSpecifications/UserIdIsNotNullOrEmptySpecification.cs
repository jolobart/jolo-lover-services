using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.WalletSpecifications.RemoveWalletSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<RemoveWalletRequest>
{
    public override bool IsSatisfiedBy(RemoveWalletRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}