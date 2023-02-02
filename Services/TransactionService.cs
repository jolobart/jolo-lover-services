using JoloLoverServices.Models;
using JoloLoverServices.Conf;
using JoloLoverServices.Interfaces;

namespace JoloLoverServices.Services
{
    public class TransactionService : ITransactionService
    {
        ApplicationContext Context;

        public TransactionService()
        {
            this.Context = new ApplicationContext();
        }

        public List<Transaction> GetAll()
        {
            return this.Context.GetTransactionLists();
        }

        public Transaction GetTransactionById(int id)
        {
            return this.GetAll().FirstOrDefault(transaction => transaction.Id == id);
        }

        public void Save(Transaction transaction)
        {
            this.GetAll().Add(transaction);
        }

        public void Delete(int id)
        {
            // Deletes transactions
        }
    }
}
