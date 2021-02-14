using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Domain
{
    public interface IPersonRepository
    {
        List<Person> getAll();
        Person Get(int id);


    }
}
