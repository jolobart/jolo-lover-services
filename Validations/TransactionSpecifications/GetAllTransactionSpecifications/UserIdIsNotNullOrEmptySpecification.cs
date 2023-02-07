using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.GetAllTransactionSpecifications;

internal class UserIdIsNotNullOrEmptySpecification : Specification<GetAllTransactionRequest>
{
    public override bool IsSatisfiedBy(GetAllTransactionRequest entity, ref ICollection<string> errors)
    {
        var result = entity.UserId != null;

        if (!result)
        {
            errors.Add("Invalid user Id");
        }

        return result;
    }
}