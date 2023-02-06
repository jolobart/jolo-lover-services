namespace JoloLoverServices.Models.Request;

public class GetTransactionRequest
{
    public int? Id { get; set; }
    public int? UserId { get; set; }
    public int? WalletId { get; set; }

    public GetTransactionRequest(int id, int userId, int walletId)
    {
        this.Id = id;
        this.UserId = userId;
        this.WalletId = walletId;
    }

    public GetTransactionRequest() { }
}