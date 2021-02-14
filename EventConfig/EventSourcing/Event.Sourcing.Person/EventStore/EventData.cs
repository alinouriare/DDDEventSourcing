using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Sourcing.Person.EventStore
{
   public class EventData
    {
        public int EventDataId { get; set; }

        public string EntityType { get; set; }

        public int EntityId { get; set; }

        public string EventType { get; set; }

        public string EventSerialzedData { get; set; }
    }
}
