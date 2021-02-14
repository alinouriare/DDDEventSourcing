using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Sourcing.Person
{
   public abstract class BaseEntity
    {
        private readonly List<IEvent> _events = new List<IEvent>();

        IEnumerable<IEvent> Events { get { return _events; } }

        public void Add(IEvent @event)
        {
            _events.Add(@event);
        }
    }
}
