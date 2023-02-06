using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.GetTransactionSpecifications;

internal class WalletIdIsNotNullOrEmptySpecification : Specification<GetTransactionRequest>
{
    public override bool IsSatisfiedBy(GetTransactionRequest entity, ref ICollection<string> errors)
    {
        var result = entity.WalletId != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}