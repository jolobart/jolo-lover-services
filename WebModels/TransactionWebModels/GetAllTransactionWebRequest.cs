using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.TransactionWebModels;

public class GetAllTransactionWebRequest
{
    [JsonRequired]
    [JsonProperty("userId")]
    public int UserId { get; set; }

    [JsonRequired]
    [JsonProperty("walletId")]
    public int WalletId { get; set; }
}
