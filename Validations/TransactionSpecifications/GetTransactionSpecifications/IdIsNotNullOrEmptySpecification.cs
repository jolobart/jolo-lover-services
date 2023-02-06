using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.GetTransactionSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<GetTransactionRequest>
{
    public override bool IsSatisfiedBy(GetTransactionRequest entity, ref ICollection<string> errors)
    {
        var result = entity.Id != null;

        if (!result)
        {
            errors.Add("Invalid transaction Id");
        }

        return result;
    }
}