namespace JoloLoverServices.Models
{
    public class Transaction
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int WalletId { get; private set; }
        public int CategoryId { get; private set; }
        public float Amount { get; private set; }
        public string Notes { get; private set; }
        public string Date { get; private set; }

        public Transaction(int id, int userId, int walletId, int categoryId, float amount, string notes, string date)
        {
            this.Id = id;
            this.UserId = userId;
            this.WalletId = walletId;
            this.CategoryId = categoryId;
            this.Amount = amount;
            this.Notes = notes;
            this.Date = date;
        }
    }
}