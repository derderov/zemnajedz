using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class PassengerModel
    {
        public int PassengerID { get; set; }
        public int IdentityID { get; set; }
        public byte PassengersTotal { get; set; }
        public bool Pets { get; set; }
        public bool Children { get; set; }
        public int LuggageDictID { get; set; }
        [StringLength(500, ErrorMessage = "Cannot be longer than 500 characters.")]
        public string Message { get; set; }

        public virtual LuggageDictModel Luggrage { get; set; }
        public virtual UserDetails IdentityDetails { get; set; }
    }
}