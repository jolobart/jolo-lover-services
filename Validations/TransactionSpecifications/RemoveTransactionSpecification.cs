using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.TransactionSpecifications.RemoveTransactionSpecifications;

namespace JoloLoverServices.Validations.TransactionSpecifications;

internal class RemoveTransactionSpecification : Specification<RemoveTransactionRequest>
{
    private static Specification<RemoveTransactionRequest> spec = new IdIsNotNullOrEmptySpecification()
        .And(new UserIdIsNotNullOrEmptySpecification())
        .And(new WalletIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(RemoveTransactionRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
