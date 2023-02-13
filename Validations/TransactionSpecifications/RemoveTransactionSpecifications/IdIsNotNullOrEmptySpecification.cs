using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.TransactionSpecifications.RemoveTransactionSpecifications;

internal class IdIsNotNullOrEmptySpecification : Specification<int>
{
    public override bool IsSatisfiedBy(int entity, ref ICollection<string> errors)
    {
        var result = entity != null;

        if (!result)
        {
            errors.Add("Invalid transaction Id");
        }

        return result;
    }
}