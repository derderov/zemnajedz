using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public int IdentityDetailsID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
        public byte NumberOfSeats { get; set; }
        public double Comfort { get; set; }
        public bool Pets { get; set; }
        public bool AirCondition { get; set; }
        public int ComfortRatingSum { get; set; }
        public int ComfortRatingTotal { get; set; }
        public bool SmokingAllowed { get; set; }

        public virtual IdentityDetails IdentityDetails { get; set; }
    }
}