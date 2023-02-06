using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.TransactionSpecifications.CreateTransactionSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<Transaction>
{
    public override bool IsSatisfiedBy(Transaction entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid transaction Id");
        }

        return result;
    }
}