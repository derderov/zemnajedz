using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZeMnaJedz.Models;

namespace ZeMnaJedz.DAL
{
    public class DataContext : DbContext
    {

        public DataContext() : base("DataContext")
        {
                          
        }

        public DbSet<CarModel> Cars { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<UserDetails> IdentityDetails { get; set; }
        public DbSet<IdentityStatisticsModel> IdentityStatistics { get; set; }
        public DbSet<OfferModel> Offers { get; set; }
        public DbSet<PassengerModel> Passangers { get; set; }
        public DbSet<LuggageDictModel> LuggageDicts { get; set; }      

    }
}