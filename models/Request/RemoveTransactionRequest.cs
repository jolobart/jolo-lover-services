namespace JoloLoverServices.Models.Request;

public class RemoveTransactionRequest
{
    public int? Id { get; set; }
    public int? UserId { get; set; }
    public int? WalletId { get; set; }

    public RemoveTransactionRequest()
    {

    }
}