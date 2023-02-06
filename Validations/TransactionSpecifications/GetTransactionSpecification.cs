using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.TransactionSpecifications.GetTransactionSpecifications;

namespace JoloLoverServices.Validations.TransactionSpecifications;

internal class GetTransactionSpecification : Specification<GetTransactionRequest>
{
    private static Specification<GetTransactionRequest> spec = new IdIsNotNullOrEmptySpecification()
        .And(new UserIdIsNotNullOrEmptySpecification())
        .And(new WalletIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(GetTransactionRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
