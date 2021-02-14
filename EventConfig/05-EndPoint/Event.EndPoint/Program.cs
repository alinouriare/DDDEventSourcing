using Event.FakeInfrastructures;
using Event.Service;
using System;

namespace Event.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new FakePerson();
            foreach (var item in p.getAll())
            {
                Console.WriteLine("name" +item.FirstName +"active"+ item.IsActive);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine();
            PersonDeactivation deactivation = new PersonDeactivation(p, new EventDispatcher());

            deactivation.Execute(1);
            foreach (var item in p.getAll())
            {
                Console.WriteLine("name" + item.FirstName + "active"+ item.IsActive);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.ReadKey();
                Console.WriteLine("Hello World!");
        }
    }
}
