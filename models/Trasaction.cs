namespace JoloLoverServices.Models
{
    public class Transaction
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public float Amount { get; private set; }
        public string Notes { get; private set; }

        public Transaction(int id, string name, float amount, string notes)
        {
            this.Id = id;
            this.Name = name;
            this.Amount = amount;
            this.Notes = notes;
        }
    }
}