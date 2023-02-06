using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.TransactionSpecifications.CreateTransactionSpecifications;

internal class CategoryIdIsNotNullOrEmptySpecification : Specification<Transaction>
{
    public override bool IsSatisfiedBy(Transaction entity, ref ICollection<string> errors)
    {
        var result = entity.CategoryId != null;

        if (!result)
        {
            errors.Add("Invalid category Id");
        }

        return result;
    }
}