using JoloLoverServices.Models;

namespace JoloLoverServices.Data.Interfaces;

public interface IUserSqlDataGateway
{
    User GetUserByEmail(string email);
}
