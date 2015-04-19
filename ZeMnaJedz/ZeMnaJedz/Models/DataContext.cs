using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ZeMnaJedz.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<IdentityDetails> Identity_Details { get; set; }
        public DbSet<IdentityStatistics> Identity_Statistics { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Passenger> Passangers { get; set; }
        public DbSet<LuggageDict> LuggageDicts { get; set; }
    }
}