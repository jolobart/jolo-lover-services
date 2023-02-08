using System.Security.Claims;
using JoloLoverServices.Models;

namespace JoloLoverServices.Factories.Interfaces;

public interface IClaimsFactory
{
    ClaimsIdentity CreateClaims(User user);
}