using Microsoft.EntityFrameworkCore;

namespace SoftDrinkDataAccess.Database
{
    public class SoftDrinkDbContext: DbContext
    {
        public DbSet<SoftDrinkPersonTable> FlightPersons { get; set; }

        public SoftDrinkDbContext(DbContextOptions<SoftDrinkDbContext> options):
            base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  modelBuilder.Entity<PersonTable>().Property(p => p.Id).UseOracleIdentityColumn();
        }
    }
}
