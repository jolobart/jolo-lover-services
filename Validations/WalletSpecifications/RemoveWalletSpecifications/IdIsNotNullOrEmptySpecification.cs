using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.WalletSpecifications.RemoveWalletSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<RemoveWalletRequest>
{
    public override bool IsSatisfiedBy(RemoveWalletRequest entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}