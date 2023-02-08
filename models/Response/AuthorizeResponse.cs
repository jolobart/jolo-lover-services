using System.Net;

namespace JoloLoverServices.Models.Response;

public class AuthorizeResponse : ResponseBase<AuthorizeResponse>
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }

    public AuthorizeResponse() : base()
    {

    }

    public AuthorizeResponse(IEnumerable<string> errorMessage) : base(errorMessage)
    {

    }

    public AuthorizeResponse(string errorMessage) : base(errorMessage)
    {

    }

    public static AuthorizeResponse Success(string accessToken, string? refreshToken)
    {
        return new AuthorizeResponse
        {
            RefreshToken = refreshToken,
            AccessToken = accessToken,
            Succeeded = true,
            Code = (int)HttpStatusCode.OK
        };
    }
}
