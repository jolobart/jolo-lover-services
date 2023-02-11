using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.WalletSpecifications.SelectWalletSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<SelectedWalletRequest>
{
    public override bool IsSatisfiedBy(SelectedWalletRequest entity, ref ICollection<string> errors)
    {
        var result = entity.WalletId != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}