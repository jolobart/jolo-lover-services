namespace JoloLoverServices.WebModels;

public abstract class WebModelBase
{

}

public class WebModelError : WebModelBase
{
    public string? Message { get; set; }
    public string? Type { get; set; }
    public int Code { get; set; }
}

public class WebModelOk<T> : WebModelBase
{
    public T? Data { get; set; }
}