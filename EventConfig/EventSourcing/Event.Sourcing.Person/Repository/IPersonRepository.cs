using Event.Sourcing.Person.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Sourcing.Person.Repository
{
   public interface IPersonRepository
    {

        Person Get(int id);

    }

    public class PersonRepository : IPersonRepository
    {
        EventDataRepository dataRepository = new EventDataRepository();
        public Person Get(int id)
        {
            var events = dataRepository.GetEventDatas(nameof(Person), id);
            Person person = new Person();
            List<IEvent> myevents = new List<IEvent>();
            foreach (var item in events)
            {
                switch (item.EventType)
                {
                    case nameof(PersonCreated):
                        PersonCreated personCreated = JsonConvert.DeserializeObject<PersonCreated>(item.EventSerialzedData);
                        myevents.Add(personCreated);
                        break;
                    case nameof(PersonEmailUpdate):
                        PersonEmailUpdate personEmailUpdate = JsonConvert.DeserializeObject<PersonEmailUpdate>(item.EventSerialzedData);
                        myevents.Add(personEmailUpdate);
                        break;
                }
            }
            person.LoadFromEvents(myevents);
            return person;

        }
    }
}
