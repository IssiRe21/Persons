using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
           Person Jack = new Person("Jack Sparrow");
           Jack.SayHello();

           Person Pedro = new Person("Pedro Juan");
           Pedro.SayHello();

          Console.WriteLine(Person.bloodColor);

          Person.PrintRace();

        }


    }

}
