using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.TransactionWebModels;

public class CreateTransactionWebRequest
{
    [JsonRequired]
    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonRequired]
    [JsonProperty("userId")]
    public int UserId { get; set; }

    [JsonRequired]
    [JsonProperty("walletId")]
    public int WalletId { get; set; }

    [JsonRequired]
    [JsonProperty("amount")]
    public float Amount { get; set; }

    [JsonRequired]
    [JsonProperty("categoryId")]
    public int CategoryId { get; set; }

    [JsonRequired]
    [JsonProperty("notes")]
    public string? Notes { get; set; }

    [JsonRequired]
    [JsonProperty("dateTime")]
    public DateTime DateTime { get; set; }
}
