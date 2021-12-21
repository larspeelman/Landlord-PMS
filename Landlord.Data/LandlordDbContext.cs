using Microsoft.EntityFrameworkCore;

namespace Landlord.Data
{
    internal class LandlordDbContext : DbContext
    {
        public LandlordDbContext(DbContextOptions options) : base(options) { }

        // DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                assembly : typeof(LandlordDbContext).Assembly);
        }
    }
}
