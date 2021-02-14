using Event.Domain;
using Event.Framework;
using System;

namespace Event.Service
{
    public class PersonDeactiveSedSms : IEventHadler<PersonDeactivated>
    {


        public void Handle(PersonDeactivated @event)
        {
            Console.WriteLine(
                "send Sms"
                );
            Console.WriteLine(
               $"Person  {@event.Email}"
               );
            Console.WriteLine("dacive");
            Console.WriteLine("-------End sms-------------");
        }
    }
}
