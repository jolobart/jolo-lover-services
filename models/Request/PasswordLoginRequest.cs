namespace JoloLoverServices.Models.Request;

public class PasswordLoginRequest
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }

    public PasswordLoginRequest() { }
}