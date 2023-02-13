using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Data.Interfaces;

public interface ITransactionSqlDataGateway
{
    List<Transaction> GetAll(GetAllTransactionRequest request);
    Transaction GetTransactionById(int id, int userId, int walletId);
    Transaction Upsert(Transaction transaction);
    Transaction Delete(int id);
}
