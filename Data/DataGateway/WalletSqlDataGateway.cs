using JoloLoverServices.Data.Interfaces;
using JoloLoverServices.Models;

namespace JoloLoverServices.Data.DataGateway;

public class WalletSqlDataGateway : IWalletSqlDataGateway
{
    private readonly DataContext _dataContext;

    public WalletSqlDataGateway(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public Wallet Delete(Wallet wallet)
    {
        _dataContext.Wallets.Remove(wallet);
        _dataContext.SaveChanges();
        return wallet;
    }

    public List<Wallet> GetAll(int id)
    {
        return _dataContext.Wallets
       .Where(w => w.UserId == id)
       .ToList();
    }

    public Wallet GetWalletById(int id, int userId)
    {
         return _dataContext.Wallets.SingleOrDefault(w => w.Id == id && w.UserId == userId);
    }

    public Wallet Upsert(Wallet wallet)
    {
        if (wallet.Id == null)
        {
            _dataContext.Wallets.Add(wallet);
        }
        else
        {
            _dataContext.Wallets.Update(wallet);
        }

        _dataContext.SaveChanges();
        return _dataContext.Wallets.Find(wallet.Id);
    }
}