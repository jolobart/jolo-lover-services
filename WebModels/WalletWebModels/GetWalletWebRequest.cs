using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.WalletWebModels;

public class GetWalletWebRequest
{
    [JsonRequired]
    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonRequired]
    [JsonProperty("userId")]
    public int UserId { get; set; }
}
