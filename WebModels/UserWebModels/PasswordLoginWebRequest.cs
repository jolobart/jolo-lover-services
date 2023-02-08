using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.UserWebModels;

public class PasswordLoginWebRequest
{
    [JsonRequired]
    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonRequired]
    [JsonProperty("password")]
    public string Password { get; set; }
}
