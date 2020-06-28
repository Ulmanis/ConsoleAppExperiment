using System;
using System.Collections.Generic;

namespace ConsoleAppExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();

            persons.Add(new Human("Geralt ", "Of Rivia", 225, "Brown"));
            persons.Add(new Human("Agent ", "Smith", 69, "Green"));
            persons.Add(new Human("Erwin ", "Rommel", 35, "Gray"));
            persons.Add(new Human("Wilhelm ", "Fon Strutzk", 55, "Brown"));

            //persons[1].SetAge(65);

            foreach(var person in persons)
            {
                person.Introduce();
            }
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Geralt", 200, "EUR"));
            accounts.Add(new BankAccount("Harold", 5000, "EUR"));
            accounts.Add(new BankAccount("Adolph", 69, "EUR"));

            foreach (var account in accounts)
            {
                account.PrintInfo();
            }

            accounts[0].MakeDeposit(100, "Birthday Gift");
            accounts[0].MakeDeposit(400, "Cukurs");
            accounts[0].MakeDeposit(50, "For Head");
            Console.WriteLine(accounts[0].Balance);
            accounts[0].MakeWithdrawal(150, "Manga");
            Console.WriteLine(accounts[0].Balance);

        }
    }


}
