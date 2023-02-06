using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.TransactionWebModels;

public class RemoveTransactionWebRequest
{
    [JsonRequired]
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonRequired]
    [JsonProperty("userId")]
    public int UserId { get; set; }

    [JsonRequired]
    [JsonProperty("walletId")]
    public int WalletId { get; set; }
}
