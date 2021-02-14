using Event.Sourcing.Person.Repository;
using System;

namespace UseEventStore
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository personRepository = new PersonRepository();

            var p1 = personRepository.Get(1);
            var p2 = personRepository.Get(2);
            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }
    }
}
