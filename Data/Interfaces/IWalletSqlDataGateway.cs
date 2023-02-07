using JoloLoverServices.Models;

namespace JoloLoverServices.Data.Interfaces;

public interface IWalletSqlDataGateway
{
    List<Wallet> GetAll(int id);
    Wallet GetWalletById(int id, int userId);
    Wallet Upsert(Wallet wallet);
    Wallet Delete(Wallet wallet);
}