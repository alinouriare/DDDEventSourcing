using Event.Framework;
using System;

namespace Event.Domain
{
    public class Person: BaseEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public bool IsActive { get; set; }


        public void Deacivate()
        {
            IsActive = false;
            AddEvent(new PersonDeactivated
            {

                Email = Email,
                Id=Id,
                Mobile=Mobile
            }) ;
        }

    }
}
