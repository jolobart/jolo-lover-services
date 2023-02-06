using JoloLoverServices.Interfaces;
using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Services.Extension.TransactionServiceExtensions;
using JoloLoverServices.Data.Interfaces;
using System.Net;

namespace JoloLoverServices.Services;

public class TransactionService : ITransactionService
{
    private readonly ITransactionSqlDataGateway _dataGateway;

    public TransactionService(ITransactionSqlDataGateway dataGateway)
    {
        _dataGateway = dataGateway;
    }

    public ResponseBase<Transaction> UpsertTransaction(Transaction request)
    {
        var response = new ResponseBase<Transaction>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var result = _dataGateway.Upsert(request);
                return response.AsData(result, HttpStatusCode.Created);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }
    public ResponseBase<List<Transaction>> GetAll(GetTransactionRequest request)
    {
        var response = new ResponseBase<List<Transaction>>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var result = _dataGateway.GetAll(request);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Transaction> GetTransactionById(GetTransactionRequest request)
    {
        var response = new ResponseBase<Transaction>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var result = _dataGateway.GetTransactionById(request.Id.Value, request.UserId.Value, request.WalletId.Value);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Transaction> RemoveTransaction(RemoveTransactionRequest request)
    {
        var response = new ResponseBase<Transaction>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var transactionResponse = GetTransactionById(request.ToGetTransactionRequest(request.Id.Value, request.UserId.Value, request.WalletId.Value));

                if (transactionResponse.Succeeded && transactionResponse.Data != null)
                {
                    var result = _dataGateway.Delete(transactionResponse.Data);
                    return response.AsData(result);
                }

                return transactionResponse;
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }
}