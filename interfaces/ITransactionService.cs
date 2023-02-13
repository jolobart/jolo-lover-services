using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Interfaces;

public interface ITransactionService
{
    ResponseBase<List<Transaction>> GetAll(GetAllTransactionRequest request);
    ResponseBase<Transaction> GetTransactionById(GetTransactionRequest request);
    ResponseBase<Transaction> UpsertTransaction(Transaction request);
    ResponseBase<Transaction> RemoveTransaction(int id);
}
