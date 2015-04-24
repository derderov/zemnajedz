using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class LuggageDictModel
    {
        [Required][Key]
        public int LuggageDictID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}