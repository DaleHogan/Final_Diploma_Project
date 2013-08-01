using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal abstract partial class Person : IPerson
    {
        public Person() { }

        public Person(Restaurant restaurant, string firstName, string lastName, string contactNumber, string email)
        {
            this.Restaurant = restaurant;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.ContactNumber = contactNumber;
        }

       
    }
}
