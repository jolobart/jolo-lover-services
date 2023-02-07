using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.WalletSpecifications.GetWalletByIdSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<GetWalletRequest>
{
    public override bool IsSatisfiedBy(GetWalletRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}