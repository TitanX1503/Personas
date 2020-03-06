using System;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Edd = new Person("Edd");
            Edd.SayHello();

            Person Eddie = new Person("Eddie");
            Eddie.SayHello();

            Console.WriteLine(Person.bloodColour);

            Person.printRace();
        }
    }
}
