using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class IdentityDetails
    {
        public int IdentityDetailsID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Voivodeship { get; set; }
        public string EMail { get; set; }
        public Int32 Phone { get; set; }
        public char Sex { get; set; }
        public bool Smoker { get; set; }
        public bool Talktive { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}