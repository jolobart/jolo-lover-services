using System.Net;
using JoloLoverServices.Factories.Interfaces;
using JoloLoverServices.Interfaces;
using JoloLoverServices.Managers.Interfaces;
using JoloLoverServices.Models;
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

    public ResponseBase<AuthorizeResponse> PasswordLogin(PasswordLoginRequest request)
    {
        var response = new ResponseBase<AuthorizeResponse>();
        ICollection<string> errors = new List<string>();

        var passwordLogin = _dataService.PasswordLogin(request);

        if (passwordLogin.Succeeded && passwordLogin.Data != null)
        {
            var user = passwordLogin.Data;
            var claims = _claimsFactory.CreateClaims(user);
            var tokens = _tokenFactory.CreateAuthTokens(claims);

            return response.Success(tokens.AccessToken, tokens.RefreshToken, HttpStatusCode.Created);
        }
        errors.Add("invalid password");
        return response.AsInvalidRequestError(errors);
    }
}
