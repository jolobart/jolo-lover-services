namespace JoloLoverServices.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WalletId { get; set; }
        public int CategoryId { get; set; }
        public float Amount { get; set; }
        public string? Notes { get; set; }
        public DateTime DateTime { get; set; }

        public Transaction(int id, int userId, int walletId, int categoryId, float amount, string notes, DateTime dateTime)
        {
            this.Id = id;
            this.UserId = userId;
            this.WalletId = walletId;
            this.CategoryId = categoryId;
            this.Amount = amount;
            this.Notes = notes;
            this.DateTime = dateTime;
        }

        public Transaction()
        {

        }
    }
}