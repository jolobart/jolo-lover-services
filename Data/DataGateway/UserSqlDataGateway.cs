using JoloLoverServices.Data.Interfaces;
using JoloLoverServices.Models;

namespace JoloLoverServices.Data.DataGateway;

public class UserSqlDataGateway : IUserSqlDataGateway
{
    private readonly DataContext _dataContext;

    public UserSqlDataGateway(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public User GetUserByEmail(string email)
    {
        return _dataContext.Users.SingleOrDefault(u => u.Email == email);
    }
}