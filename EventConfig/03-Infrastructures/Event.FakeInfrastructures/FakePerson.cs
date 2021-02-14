using Event.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Event.FakeInfrastructures
{
    public class FakePerson : IPersonRepository
    {
        private static List<Person> People = new List<Person>()
        {
            new Person{  FirstName="Ali",LastName="Nouri",Id=1,Mobile="09359504672",IsActive=true,Email="alinouriare@yahoo.com"},
            new Person{  FirstName="Omid",LastName="Khaleghi",Id=1,Mobile="09359504672",IsActive=true,Email="alinouriare@yahoo.com"}
        };
        public Person Get(int id)
        {
            return People.FirstOrDefault(c => c.Id == id);
        }

       public List<Person> getAll()
        {
            return People.ToList();
        }
    }
}
