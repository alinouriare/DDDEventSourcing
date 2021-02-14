using Event.Domain;
using Event.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Service
{
    public class PersonDeactiveSedEmail : IEventHadler<PersonDeactivated>
    {
      

        public void Handle(PersonDeactivated @event)
        {
            Console.WriteLine(
                "send Email"
                );
            Console.WriteLine(
               $"Person  {@event.Email}"
               );
            Console.WriteLine("dacive");
            Console.WriteLine("---------EndEmail-----------");
        }
    }
}
