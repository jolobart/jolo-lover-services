namespace JoloLoverServices.Models
{
    public class Response
    {

        public bool Success { get; set; }
        public List<ErrorMessage>? ErrorMessages { get; set; }
    }
}