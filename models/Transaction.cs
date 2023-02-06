namespace JoloLoverServices.Models;

public class Transaction
{
    public int? Id { get; set; }
    public int? UserId { get; set; }
    public int? WalletId { get; set; }
    public int? CategoryId { get; set; }
    public Category Category { get; set; }
    public float Amount { get; set; }
    public string? Notes { get; set; }
    public DateTime DateTime { get; set; }
}
