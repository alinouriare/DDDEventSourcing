using Event.Sourcing.Person.Events;
using Event.Sourcing.Person.EventStore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Sourcing.Person.Repository
{
   public class EventDataRepository
    {
        private readonly List<EventData> eventDatas = new List<EventData>();

        public EventDataRepository()
        {
            eventDatas.Add(new EventData
            {
                EventDataId = 1,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EntityId = 1,
                EventSerialzedData = JsonConvert.SerializeObject(new PersonCreated
                {
                    Id = 1,
                    Email = "alinouriare@yahoo.com",
                    FirstName = "ali",
                    LastName = "nouri"
                })

            });
            eventDatas.Add(new EventData
            {
                EventDataId = 2,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EntityId = 2,
                EventSerialzedData = JsonConvert.SerializeObject(new PersonCreated
                {
                    Id = 2,
                    Email = "rezaakabri@yahoo.com",
                    FirstName = "reza",
                    LastName = "akbari"
                })

            });
            eventDatas.Add(new EventData
            {
                EventDataId = 3,
                EntityType = nameof(Person),
                EventType = nameof(PersonEmailUpdate),
                EntityId = 1,
                EventSerialzedData = JsonConvert.SerializeObject(new PersonEmailUpdate
                {
                   
                    Email = "alinouriare@gmail.com",
                  
                })

            });

            eventDatas.Add(new EventData
            {
                EventDataId = 4,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EntityId = 3,
                EventSerialzedData = JsonConvert.SerializeObject(new PersonCreated
                {
                    Id =3,
                    Email = "hamzeh@yahoo.com",
                    FirstName = "hamzeh",
                    LastName = "taghvi"
                })

            });
        }

        public List<EventData> GetEventDatas(string entityType ,int entityId)
        {
            List<EventData> result = eventDatas.Where(c => c.EntityId == entityId && c.EntityType == entityType).ToList();
            return result;
        }
    }
}
