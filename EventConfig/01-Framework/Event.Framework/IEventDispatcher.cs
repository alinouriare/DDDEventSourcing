using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Framework
{
  public  interface IEventDispatcher
    {
        void Dispatche<T>(params T[] events) where T : IEvent;
    }
}
