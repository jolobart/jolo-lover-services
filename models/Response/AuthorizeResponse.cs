using System.Net;

namespace JoloLoverServices.Models.Response;

public class AuthorizeResponse
{
    public string AccessToken { get; set; }
    public string? RefreshToken { get; set; }

    public AuthorizeResponse()
    {

    }
}
