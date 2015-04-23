﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class Evaluation
    {
        public int EvaluationID { get; set; }
        public int IdentityDetailsID { get; set; }
        public int CarID { get; set; }
        public int OfferID { get; set; }
        public byte Safety { get; set; }
        public byte Comfort { get; set; }
        public byte OveralRating { get; set; }

        public virtual UserDetails IdentityDetails { get; set; }
    }
}