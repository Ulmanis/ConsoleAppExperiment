using System;

namespace ConsoleAppExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person;
            person = new Human("Geralt ", "Of Rivia", 225, "Brown");
            person.Introduce();

            person.AddNumbers(person.Age, 100); 
        }
    }


}
