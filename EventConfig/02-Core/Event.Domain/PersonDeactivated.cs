using Event.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Domain
{
   public class PersonDeactivated:IEvent
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

    }
}
