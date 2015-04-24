using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ZeMnaJedz.Models
{
    public class CarModel
    {
        [Required][Key]
        public int CarID { get; set; }

        public int IdentityDetailsID { get; set; }

        [Required]
        [Display(Name="Marka")]
        public string Brand { get; set; }
        
        [Required]
        [Display(Name="Model")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Liczba miejsc")]
        [Range(2, 20)]
        public byte NumberOfSeats { get; set; }

        [Display(Name="Rok produkcji")]
        [Range(1900,2015)]
        public short Year { get; set; }

        [Display(Name="Komfort")]
        public double Comfort { get; set; }
        
        [Display(Name="Zwierzęta")]
        public bool Pets { get; set; }

        [Display(Name="Klimatyzacja")]
        public bool AirCondition { get; set; }

        [Display(Name="Czy wolno palić")]
        public bool SmokingAllowed { get; set; }

        /// <summary>
        /// Do podliczenia średniej oceny komfortu.
        /// </summary>
        public int ComfortRatingSum { get; set; }

        /// <summary>
        /// Do podliczenia średniej oceny komfortu.
        /// </summary>
        public int ComfortRatingTotal { get; set; }

        public virtual ApplicationUser IdentityDetails { get; set; }
    }
}