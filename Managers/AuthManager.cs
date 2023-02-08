using JoloLoverServices.Factories.Interfaces;
using JoloLoverServices.Interfaces;
using JoloLoverServices.Managers.Interfaces;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Models.Response;

namespace JoloLoverServices.Managers;

internal class AuthManager : IAuthManager
{
    private readonly IUserService _dataService;
    private readonly IClaimsFactory _claimsFactory;
    private readonly ITokenFactory _tokenFactory;

    public AuthManager(IUserService dataService, IClaimsFactory claimsFactory, ITokenFactory tokenFactory)
    {
        _dataService = dataService;
        _claimsFactory = claimsFactory;
        _tokenFactory = tokenFactory;
    }

    public AuthorizeResponse PasswordLogin(PasswordLoginRequest request)
    {
        var passwordLogin = _dataService.PasswordLogin(request);

        if (passwordLogin.Succeeded && passwordLogin.Data != null)
        {
            var user = passwordLogin.Data;
            var claims = _claimsFactory.CreateClaims(user);
            var tokens = _tokenFactory.CreateAuthTokens(claims);
            
            return AuthorizeResponse.Success(tokens.AccessToken, tokens.RefreshToken);
        }

        return new AuthorizeResponse("invalid password");
    }
}
