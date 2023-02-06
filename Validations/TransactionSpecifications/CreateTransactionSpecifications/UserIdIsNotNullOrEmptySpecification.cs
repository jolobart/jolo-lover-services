using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.TransactionSpecifications.CreateTransactionSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<Transaction>
{
    public override bool IsSatisfiedBy(Transaction entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}