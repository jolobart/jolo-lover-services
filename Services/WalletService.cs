using JoloLoverServices.Interfaces;
using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Services.Extension.WalletServiceExtensions;
using JoloLoverServices.Data.Interfaces;
using System.Net;

namespace JoloLoverServices.Services;

public class WalletService : IWalletService
{
    private readonly IWalletSqlDataGateway _dataGateway;

    public WalletService(IWalletSqlDataGateway dataGateway)
    {
        _dataGateway = dataGateway;
    }

    public ResponseBase<List<Wallet>> GetAll(int id)
    {
        var response = new ResponseBase<List<Wallet>>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (id.IsValid(ref errors))
            {
                var result = _dataGateway.GetAll(id);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Wallet> GetWalletById(GetWalletRequest request)
    {
        var response = new ResponseBase<Wallet>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var result = _dataGateway.GetWalletById(request.Id.Value, request.UserId.Value);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Wallet> RemoveWallet(RemoveWalletRequest request)
    {
        var response = new ResponseBase<Wallet>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var walletResponse = GetWalletById(request.ToGetWalletRequest(request.Id.Value, request.UserId.Value));

                if (walletResponse.Succeeded && walletResponse.Data != null)
                {
                    var result = _dataGateway.Delete(walletResponse.Data);
                    return response.AsData(result);
                }

                return walletResponse;
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Wallet> UpsertWallet(Wallet request)
    {
        var response = new ResponseBase<Wallet>();
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

    public ResponseBase<Wallet> SelectWallet(SelectedWalletRequest request)
    {
        var response = new ResponseBase<Wallet>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var result = _dataGateway.SelectWallet(request);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }
}