using JoloLoverServices.Data.Interfaces;
using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Data.DataGateway;

public class TransactionSqlDataGateway : ITransactionSqlDataGateway
{
    private readonly DataContext _dataContext;

    public TransactionSqlDataGateway(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public List<Transaction> GetAll(GetAllTransactionRequest request)
    {
        return _dataContext.Transactions
        .Where(t => t.UserId == request.UserId && t.WalletId == request.WalletId)
        .ToList();
    }

    public Transaction GetTransactionById(int id, int userId, int walletId)
    {
        return _dataContext.Transactions.SingleOrDefault(t => t.Id == id && t.UserId == userId && t.WalletId == walletId);
    }

    public Transaction Upsert(Transaction transaction)
    {
        if (transaction.Id == null)
        {
            _dataContext.Transactions.Add(transaction);
        }
        else
        {
            _dataContext.Transactions.Update(transaction);
        }

        _dataContext.SaveChanges();
        return _dataContext.Transactions.Find(transaction.Id);
    }

    public Transaction Delete(Transaction transaction)
    {
        _dataContext.Transactions.Remove(transaction);
        _dataContext.SaveChanges();
        return transaction;
    }
}