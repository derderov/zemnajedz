using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ZeMnaJedz.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<CarModel> Cars { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<IdentityStatisticsModel> IdentityStatistics { get; set; }
        public DbSet<OfferModel> Offers { get; set; }
        public DbSet<PassengerModel> Passangers { get; set; }
        public DbSet<LuggageDictModel> LuggageDicts { get; set; }

        public ApplicationDbContext()
            : base("DataContext")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}