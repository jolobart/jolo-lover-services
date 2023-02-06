namespace JoloLoverServices.Models.Request;

public class RemoveTransactionRequest
{
    public int? Id { get; set; }
    public int? UserId { get; set; }
    public int? WalletId { get; set; }

    public RemoveTransactionRequest(int id, int userId, int walletId)
    {
        this.Id = id;
        this.UserId = userId;
        this.WalletId = walletId;
    }

    public RemoveTransactionRequest()
    {

    }
}