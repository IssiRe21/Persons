using System;

namespace Persons
{
    class Person
    {
        //atributo
        private string name;
        static public string bloodColor = "Red";
        public Person(string name) {
        this.name = name;
        }

        // Metodo
        public void SayHello (){
            Console.WriteLine("Hello, my name is "+ this.name);
        }

        static public void PrintRace(){
            Console.WriteLine("Human");

        }


    }
}
