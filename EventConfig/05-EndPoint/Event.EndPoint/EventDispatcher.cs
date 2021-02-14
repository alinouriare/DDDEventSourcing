using Event.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Event.EndPoint
{
    public class EventDispatcher : IEventDispatcher
    {
        public void Dispatche<T>(params T[] events) where T : IEvent
        {
            var _handlers = AppDomain.CurrentDomain.GetAssemblies().SelectMany(c =>
                c.GetTypes().Where(x => x.GetInterfaces().Any(y => y.IsGenericType && y.GetGenericTypeDefinition() == typeof(IEventHadler<>)))).ToList();

            foreach (var @event in events)
            {
                if (@event == null)
                    throw new ArgumentNullException(nameof(@event), "Event can not be null.");

                foreach (var handler in _handlers)
                {
                    bool canHandleEvent = handler.GetInterfaces()
                        .Any(x => x.IsGenericType
                            && x.GetGenericTypeDefinition() == typeof(IEventHadler<>)
                            && x.GenericTypeArguments[0] == @event.GetType());
                    if (canHandleEvent)
                    {
                        var instance = Activator.CreateInstance(handler);

                        var method = instance.GetType().GetRuntimeMethods().First(x => x.Name.Equals("Handle"));
                        object[] parametersArray = new object[] { @event };
                        method.Invoke(instance, parametersArray);
                    }

                }
            }
        }
    }
}
