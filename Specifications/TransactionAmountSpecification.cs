using JoloLoverServices.Interfaces;
using JoloLoverServices.Models;

namespace JoloLoverServices.Specification
{
    public class TransactionAmountSpecification : ISpecification<Transaction>
    {

        public bool IsSatisfiedBy(Transaction obj)
        {
            return obj.Amount > 0;
        }
        public string ErrorMessage => "Amount must be greater that zero";
    }
}