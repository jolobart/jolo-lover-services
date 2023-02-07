using JoloLoverServices.Models.Request;
using JoloLoverServices.Validations.TransactionSpecifications.GetAllTransactionSpecifications;

namespace JoloLoverServices.Validations.TransactionSpecifications;

internal class GetAllTransactionSpecification : Specification<GetAllTransactionRequest>
{
    private static Specification<GetAllTransactionRequest> spec = new UserIdIsNotNullOrEmptySpecification()
    .And(new WalletIdIsNotNullOrEmptySpecification());

    public override bool IsSatisfiedBy(GetAllTransactionRequest entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
