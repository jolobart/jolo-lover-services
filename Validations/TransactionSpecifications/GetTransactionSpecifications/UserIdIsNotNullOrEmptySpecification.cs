using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.GetTransactionSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<GetTransactionRequest>
{
    public override bool IsSatisfiedBy(GetTransactionRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}