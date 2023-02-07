using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.CategoryWebModels;

public class CategoryWebRequest
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
    [JsonProperty("type")]
    public string Type { get; set; }
}
