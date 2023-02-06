using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.RemoveTransactionSpecifications;

internal class WalletIdIsNotNullOrEmptySpecification : Specification<RemoveTransactionRequest>
{
    public override bool IsSatisfiedBy(RemoveTransactionRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}