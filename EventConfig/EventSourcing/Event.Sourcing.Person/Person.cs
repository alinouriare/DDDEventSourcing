using Event.Sourcing.Person.Events;
using System;
using System.Collections.Generic;

namespace Event.Sourcing.Person
{
    public class Person: BaseEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public void LoadFromEvents(List<IEvent> list)
        {
            foreach (var item in list)
            {
                switch (item.GetType().Name)
                {
                    case "PersonCreated":
                        LoadCreattation(item as PersonCreated);
                        break;
                    case "PersonEmailUpdate":
                        LoadEmailUpdate(item as PersonEmailUpdate);
                        break;
                }
            }
        }

        private void LoadCreattation(PersonCreated personCreated )
        {
            Id = personCreated.Id;
            Email = personCreated.Email;
            FirstName = personCreated.FirstName;
            LastName = personCreated.LastName;
        }
        private void LoadEmailUpdate(PersonEmailUpdate  personEmailUpdate)
        {
          
            Email = personEmailUpdate.Email;
      
        }
    }
}
