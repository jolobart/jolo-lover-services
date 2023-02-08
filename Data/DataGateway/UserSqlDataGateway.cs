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

    public User FindById(int id)
    {
        return _dataContext.Users.SingleOrDefault(u => u.Id == id);
    }

    public User GetUserByEmail(string email)
    {
        return _dataContext.Users.SingleOrDefault(u => u.Email == email);
    }

    public User Save(User user)
    {
        _dataContext.Users.Add(user);
        _dataContext.SaveChanges();
        return _dataContext.Users.Find(user.Id);
    }
}