namespace JoloLoverServices.Models.Request;

public class GetAllTransactionRequest
{
    public int? UserId { get; set; }
    public int? WalletId { get; set; }

    public GetAllTransactionRequest() { }
}