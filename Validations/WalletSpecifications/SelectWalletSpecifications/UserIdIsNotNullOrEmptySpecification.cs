using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.WalletSpecifications.SelectWalletSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<SelectedWalletRequest>
{
    public override bool IsSatisfiedBy(SelectedWalletRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}