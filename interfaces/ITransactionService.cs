using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Interfaces;

public interface ITransactionService
{
    ResponseBase<List<Transaction>> GetAll(GetTransactionRequest request);
    ResponseBase<Transaction> GetTransactionById(GetTransactionRequest request);
    ResponseBase<Transaction> UpsertTransaction(Transaction request);
    ResponseBase<Transaction> RemoveTransaction(RemoveTransactionRequest request);
}
