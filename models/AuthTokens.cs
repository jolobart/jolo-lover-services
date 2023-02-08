namespace JoloLoverServices.Models;

public class AuthTokens
{
    public string AccessToken { get; set; }
    public string? RefreshToken { get; set; }

    public AuthTokens(string accessToken, string? refreshToken)
    {
        this.AccessToken = accessToken;
        this.RefreshToken = refreshToken;
    }
}