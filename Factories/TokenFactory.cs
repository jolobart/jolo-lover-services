using System.Security.Claims;
using JoloLoverServices.Models;
using JoloLoverServices.Factories.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace JoloLoverServices.Factories;

public class TokenFactory : ITokenFactory
{
    private readonly SymmetricSecurityKey _securityKey;
    private readonly JwtSecurityTokenHandler _tokenHandler;
    private readonly TokenValidationParameters _validationParameters;
    public TokenFactory()
    {
        _securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AuthTokenCreationParameters.SecretKey));
        _tokenHandler = new JwtSecurityTokenHandler();
        _validationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = _securityKey,
            ValidateIssuer = false,
            ValidateAudience = false,
            ClockSkew = TimeSpan.Zero
        };
    }

    public string GenerateJWT(ClaimsIdentity claims)
    {
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = claims,
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha256Signature)
        };

        var token = _tokenHandler.CreateToken(tokenDescriptor);
        return _tokenHandler.WriteToken(token);
    }

    public AuthTokens CreateAuthTokens(ClaimsIdentity claims)
    {
        var accessToken = this.GenerateJWT(claims);
        return new AuthTokens(accessToken, null);
    }
}