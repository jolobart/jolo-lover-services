using System.Security.Claims;
using JoloLoverServices.Models;

namespace JoloLoverServices.Factories.Interfaces;

public interface ITokenFactory
{
    public string GenerateJWT(ClaimsIdentity claims);
    AuthTokens CreateAuthTokens(ClaimsIdentity claims);
}