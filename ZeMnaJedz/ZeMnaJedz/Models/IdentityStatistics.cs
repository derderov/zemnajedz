using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class IdentityStatistics
    {
        public int IdentityId { get; set; }
        public int OffersPosted { get; set; }
        public int OffersTaken { get; set; }
        public int RatingSum { get; set; }
        public int SafetyRatingSum { get; set; }
        public int RatingTotal { get; set; }
        public int SafetyRatingTotal { get; set; }

        public virtual IdentityDetails IdentityDetails { get; set; }
    }
}