using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.GetAllTransactionSpecifications;

internal class WalletIdIsNotNullOrEmptySpecification : Specification<GetAllTransactionRequest>
{
    public override bool IsSatisfiedBy(GetAllTransactionRequest entity, ref ICollection<string> errors)
    {
        var result = entity.WalletId != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}