namespace JoloLoverServices.Models.Request;

public class GetCategoryRequest
{
    public int? Id { get; set; }
    public int? UserId { get; set; }

    public GetCategoryRequest() { }
}