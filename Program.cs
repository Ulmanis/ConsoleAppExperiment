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

            persons[1].SetAge(65);

            //persons[0].SayName();
            //persons[1].SayName();
            //persons[2].SayName();

            //for(int i = 0; i < persons.Count; i++)
            //{
            //    persons[i].Introduce();
            //}

            foreach(var person in persons)
            {
                person.Introduce();
            }
        }
    }


}
