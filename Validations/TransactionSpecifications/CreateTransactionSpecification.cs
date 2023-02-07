using JoloLoverServices.Models;
using JoloLoverServices.Validations.TransactionSpecifications.CreateTransactionSpecifications;

namespace JoloLoverServices.Validations.TransactionSpecifications;

internal class CreateTransactionSpecification : Specification<Transaction>
{
    private static Specification<Transaction> spec = new IdIsNotNullOrEmptySpecification()
        .Or(new UserIdIsNotNullOrEmptySpecification())
        .And(new WalletIdIsNotNullOrEmptySpecification())
        .And(new CategoryIdIsNotNullOrEmptySpecification())
        .And(new AmountIsNotLowerThanZeroSpecification());

    public override bool IsSatisfiedBy(Transaction entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
