using Event.Domain;
using Event.Framework;
using System;
using System.Linq;

namespace Event.Service
{
    public class PersonDeactivation
    {
        private IPersonRepository personRepository;
        private IEventDispatcher eventDispatcher;
        public PersonDeactivation(IPersonRepository personRepository, IEventDispatcher eventDispatcher)
        {
            this.personRepository = personRepository;
            this.eventDispatcher = eventDispatcher;
        }

        public void Execute(int id)
        {
            var p = personRepository.Get(id);
            p.Deacivate();
            eventDispatcher.Dispatche(p.Events.ToArray());/////unit of work store
            //sed email
            //sed sms
        }
    }
}
