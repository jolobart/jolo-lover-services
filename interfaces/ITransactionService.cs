using JoloLoverServices.Models;

namespace JoloLoverServices.Interfaces
{
    public interface ITransactionService
    {
        List<Transaction> GetAll();
        Transaction GetTransactionById(int id);
        void Save(Transaction transaction);
    }
}