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
        throw new NotImplementedException();
    }

    public ResponseBase<Wallet> GetWalletById(GetWalletRequest request)
    {
        throw new NotImplementedException();
    }

    public ResponseBase<Wallet> RemoveWallet(RemoveWalletRequest request)
    {
        throw new NotImplementedException();
    }

    public ResponseBase<Wallet> UpsertWallet(Wallet request)
    {
        throw new NotImplementedException();
    }
}