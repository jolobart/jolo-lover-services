using Newtonsoft.Json;

namespace JoloLoverServices.WebModels.CategoryWebModels;

public class GetCategoryWebRequest
{
    [JsonRequired]
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonRequired]
    [JsonProperty("userId")]
    public int UserId { get; set; }
}
