using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Interfaces;

public interface IWalletService
{
    ResponseBase<List<Wallet>> GetAll(int id);
    ResponseBase<Wallet> GetWalletById(GetWalletRequest request);
    ResponseBase<Wallet> UpsertWallet(Wallet request);
    ResponseBase<Wallet> RemoveWallet(RemoveWalletRequest request);
}
