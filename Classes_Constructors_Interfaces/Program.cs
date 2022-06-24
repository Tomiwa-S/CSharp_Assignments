using System;

namespace Classes_Constructors_Interfaces
{
    public interface ITransaction
    {
        void showTransaction();
        double getAmount();
    }
    class Transaction : ITransaction
    {
        private string tCode;
        private string date;
        private double amount;
        public Transaction()
        {   
            tCode = "";
            date = "";
            amount = 0.0;
        }
        public Transaction(string tCode, string date, double amount)
        {
            this.tCode = tCode;
            this.date = date;
            this.amount = amount;
        }
        public double getAmount()
        {
            return amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction {0}", tCode);
            Console.WriteLine("Date : {0}", date);
            Console.WriteLine("Amount : {0}", amount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            Console.WriteLine();
            t2.showTransaction();
            Console.WriteLine();
            Console.WriteLine(t1.getAmount());
        }
    }
}
