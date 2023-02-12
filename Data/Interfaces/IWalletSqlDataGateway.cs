using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Data.Interfaces;

public interface IWalletSqlDataGateway
{
    List<Wallet> GetAll(int id);
    Wallet GetWalletById(int id, int userId);
    Wallet Upsert(Wallet wallet);
    Wallet Delete(int id);
    Wallet SelectWallet(SelectedWalletRequest request);
}