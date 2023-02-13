using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.TransactionSpecifications.RemoveTransactionSpecifications;

namespace JoloLoverServices.Validations.TransactionSpecifications;

internal class RemoveTransactionSpecification : Specification<int>
{
    private static Specification<int> spec = new IdIsNotNullOrEmptySpecification();

    public override bool IsSatisfiedBy(int entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
