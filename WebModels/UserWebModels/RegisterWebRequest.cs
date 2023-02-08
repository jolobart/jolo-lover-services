using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.UserWebModels;

public class RegisterWebRequest
{
    [JsonRequired]
    [JsonProperty("firstname")]
    public string Firstname { get; set; }

    [JsonRequired]
    [JsonProperty("lastname")]
    public string Lastname { get; set; }

    [JsonRequired]
    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonRequired]
    [JsonProperty("password")]
    public string Password { get; set; }
}
