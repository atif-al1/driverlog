using Microsoft.EntityFrameworkCore;

namespace Drivers.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions options) : base(options){}

        public DbSet<Trip> Trips{get;set;}
    }
}