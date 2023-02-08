namespace JoloLoverServices.Models.Request;

public class RegisterRequest
{
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public RegisterRequest()
    {

    }
}
