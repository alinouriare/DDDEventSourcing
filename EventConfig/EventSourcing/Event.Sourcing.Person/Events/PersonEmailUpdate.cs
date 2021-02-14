using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Sourcing.Person.Events
{
   public class PersonEmailUpdate:IEvent
    {
        public string Email { get; set; }
    }
}
