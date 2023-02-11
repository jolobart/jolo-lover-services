using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.WalletWebModels;

public class SelectedWalletWebRequest
{
    [JsonRequired]
    [JsonProperty("walletId")]
    public int WalletId { get; set; }

    [JsonRequired]
    [JsonProperty("userId")]
    public int UserId { get; set; }
}
