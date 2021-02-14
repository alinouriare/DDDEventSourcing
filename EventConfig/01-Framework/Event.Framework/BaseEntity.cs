using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Framework
{
   public abstract class BaseEntity
    {

        private readonly List<IEvent> _events = new List<IEvent>();

        public IEnumerable<IEvent> Events { get { return _events; } }

        protected void AddEvent(IEvent @event)
        {

            _events.Add(@event);
        }

        protected void ClearEvent()
        {
            _events.Clear();
        }
    }
}
