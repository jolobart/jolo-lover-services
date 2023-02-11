namespace JoloLoverServices.Models;

public class User
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public int? SelectedWalletId { get; set; }
    public List<Wallet> Wallets { get; set; }
}