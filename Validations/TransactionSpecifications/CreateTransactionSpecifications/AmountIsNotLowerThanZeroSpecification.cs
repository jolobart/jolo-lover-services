using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.TransactionSpecifications.CreateTransactionSpecifications;

internal class AmountIsNotLowerThanZeroSpecification : Specification<Transaction>
{
    public override bool IsSatisfiedBy(Transaction entity, ref ICollection<string> errors)
    {
        var result = entity.Amount > 0;

        if (!result)
        {
            errors.Add("Amount must be greater that 0");
        }

        return result;
    }
}