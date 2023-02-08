using JoloLoverServices.Models;

namespace JoloLoverServices.Data.Interfaces;

public interface IUserSqlDataGateway
{
    User GetUserByEmail(string email);
    User Save(User user);
    User FindById(int id);
}
