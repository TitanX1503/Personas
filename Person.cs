using System;

namespace Personas
{
    class Person
    {
        private string name;

        static public string BloodColour = "idunno"; //cuz im brittish :b

        public Person(string name)
        {
            this.name = name;
        }

        public void SayHello()
        {
            Console.WriteLine("I am the only " + this.name + " in this place my boi!");
        }

        static public void printRace()
        {
            Console.WriteLine("Hiumen");

        }
    }
}