using System.Security.Claims;
using JoloLoverServices.Factories.Interfaces;
using JoloLoverServices.Models;

namespace JoloLoverServices.Factories;

public class ClaimsFactory : IClaimsFactory
{
    public ClaimsIdentity CreateClaims(User user)
    {
        var claims = new List<Claim>
    {
        new Claim("id", user.Id.ToString())
    };

        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        return claimsIdentity;
    }
}