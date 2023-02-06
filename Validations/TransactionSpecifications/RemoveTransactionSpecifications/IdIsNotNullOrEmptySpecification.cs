using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.RemoveTransactionSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<RemoveTransactionRequest>
{
    public override bool IsSatisfiedBy(RemoveTransactionRequest entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid transaction Id");
        }

        return result;
    }
}