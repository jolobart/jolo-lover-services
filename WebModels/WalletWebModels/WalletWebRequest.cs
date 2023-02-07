using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.WalletWebModels;

public class WalletWebRequest
{
    [JsonRequired]
    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonRequired]
    [JsonProperty("userId")]
    public int UserId { get; set; }

    [JsonRequired]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonRequired]
    [JsonProperty("balance")]
    public float Balance { get; set; }

    [JsonRequired]
    [JsonProperty("currency")]
    public string Currency { get; set; }
}
