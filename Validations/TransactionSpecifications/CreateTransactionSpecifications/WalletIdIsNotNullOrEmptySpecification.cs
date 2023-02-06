using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.TransactionSpecifications.CreateTransactionSpecifications;

internal class WalletIdIsNotNullOrEmptySpecification : Specification<Transaction>
{
    public override bool IsSatisfiedBy(Transaction entity, ref ICollection<string> errors)
    {
        var result = entity.WalletId != null;

        if (!result)
        {
            errors.Add("Invalid wallet Id");
        }

        return result;
    }
}