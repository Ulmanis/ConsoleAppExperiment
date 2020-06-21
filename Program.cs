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
            accounts[0].PrintInfo();
            accounts.Add(new BankAccount("Harold", 5000, "EUR"));
            accounts[1].PrintInfo();
            accounts.Add(new BankAccount("Adolph", 69, "EUR"));
            accounts[2].PrintInfo();

        }
    }


}
