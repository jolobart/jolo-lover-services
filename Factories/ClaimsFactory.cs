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
        new Claim("user.id", user.Id.ToString()),
        new Claim("user.name", user.Name),
        new Claim(ClaimTypes.Email, user.Email)
    };

        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        return claimsIdentity;
    }
}