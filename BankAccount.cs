using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExperiment
{
    class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();

        private static int accountNumber = 9114566;
        public string Number { get; }

        public string Owner { get; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var t in transactions)
                {
                    balance += t.Amount;
                }
                return balance;
            }
        }
        public DateTime Created { get; }

        public string Currency { get; }
        public BankAccount(string owner, decimal balance, string currency)
        {
            this.Number = accountNumber.ToString();
            accountNumber++;
            this.Owner = owner;
            this.MakeDeposit(balance, "Initial Balance");
            this.Currency = currency;
            this.Created = DateTime.Now;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number {this.Number} created on {this.Created.ToShortDateString()} belongs to {this.Owner} with {this.Balance} {this.Currency}");
        }

        public void MakeDeposit(decimal amount, string note)
        {
            Transaction deposit = new Transaction(amount, note);
            transactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, string note)
        {
            if(amount < 0)
            {
                Console.WriteLine("Amount must be positive");
            }
            else if(amount > this.Balance)
            {
                Console.WriteLine("You broke bruh");
                return;
            }
            Transaction withdrawal = new Transaction(-amount, note);
            transactions.Add(withdrawal);
        }

    }
}
