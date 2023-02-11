using JoloLoverServices.Data.Interfaces;
using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Data.DataGateway;

public class WalletSqlDataGateway : IWalletSqlDataGateway
{
    private readonly DataContext _dataContext;
    private readonly IUserSqlDataGateway _userSqlDataGateway;

    public WalletSqlDataGateway(DataContext dataContext, IUserSqlDataGateway userSqlDataGateway)
    {
        _dataContext = dataContext;
        _userSqlDataGateway = userSqlDataGateway;
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

    public Wallet SelectWallet(SelectedWalletRequest request)
    {
        var user = _userSqlDataGateway.FindById(request.UserId);

        if (user != null)
        {
            user.SelectedWalletId = request.WalletId;
            _dataContext.Users.Update(user);
            _dataContext.SaveChanges();
        }

        return _dataContext.Wallets.Find(request.WalletId);
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