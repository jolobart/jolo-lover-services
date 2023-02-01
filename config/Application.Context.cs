using JoloLoverServices.Models;

namespace JoloLoverServices.Conf
{
    public class ApplicationContext
    {
        private List<Transaction> TransactionLists;
        Transaction TransactionItem1;
        Transaction TransactionItem2;
        private static ApplicationContext instance = null;

        public static ApplicationContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationContext();
                }
                return instance;
            }
        }

        public ApplicationContext()
        {
            this.TransactionLists = new List<Transaction>();
            this.TransactionItem1 = new Transaction(1, "Food and Beverage", 115.00f, "Jollibee spaghetti and burger steak");
            this.TransactionItem2 = new Transaction(2, "Transportation", 13.00f, "BGC bus fare");

            this.TransactionLists.Add(this.TransactionItem1);
            this.TransactionLists.Add(this.TransactionItem2);
        }

        public List<Transaction> GetTransactionLists()
        {
            return this.TransactionLists;
        }
    }
}