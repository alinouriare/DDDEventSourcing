using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Framework
{
   public interface IEventHadler<in T> where T:IEvent
    {
        void Handle(T @event);
    }
}
