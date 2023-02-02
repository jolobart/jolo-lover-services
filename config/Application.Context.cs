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
        }

        public List<Transaction> GetTransactionLists()
        {
            return this.TransactionLists;
        }
    }
}