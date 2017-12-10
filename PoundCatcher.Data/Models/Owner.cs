using System;
using System.Collections.Generic;
using System.Text;

namespace PoundCatcher.Data.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public virtual IEnumerable<Dog> Dogs { get; set; }
    }
}
