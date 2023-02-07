using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.WalletSpecifications.GetWalletByIdSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<GetWalletRequest>
{
    public override bool IsSatisfiedBy(GetWalletRequest entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}