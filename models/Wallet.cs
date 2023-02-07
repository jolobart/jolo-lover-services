namespace JoloLoverServices.Models;

public class Wallet
{
    public int? Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public float Balance { get; set; }
    public string Currency { get; set; }
    public List<Transaction> Transactions { get; set; }
}
