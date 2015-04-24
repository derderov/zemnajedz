using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class OfferModel
    {
        [Required][Key]
        public int OfferID { get; set; }
        public int IdentityDetailsID { get; set; }
        public int CarID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Destination { get; set; }
        public DateTime When { get; set; }
        public short NumberOfSeats { get; set; }
        public string Login { get; set; }
        public double Price { get; set; }
        public short StreetNumber { get; set; }
        [StringLength(500, ErrorMessage = "Cannot be longer than 500 characters.")]
        public string AdditionalInfo { get; set; }
        public ICollection<PassengerModel> Passengers { get; set; }
        public virtual CarModel Car { get; set; }
    }
}