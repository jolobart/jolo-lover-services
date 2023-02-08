using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.UserWebModels;

public class AuthTokensViewModel
{
    [JsonRequired]
    [JsonProperty("accessToken")]
    public string AccessToken { get; set; }

    [JsonRequired]
    [JsonProperty("refreshToken")]
    public string? RefreshToken { get; set; }

    public AuthTokensViewModel(string accessToken, string refreshToken)
    {
        this.AccessToken = accessToken;
        this.RefreshToken = refreshToken;
    }
}
