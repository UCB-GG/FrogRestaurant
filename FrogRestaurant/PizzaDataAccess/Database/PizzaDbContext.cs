using Microsoft.EntityFrameworkCore;

namespace PizzaDataAccess.Database
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<PizzaPersonTable> Persons { get; set; }
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //   modelBuilder.Entity<BusPersonTable>().Property(p => p.Id).UseOracleIdentityColumn();
        }
    }
}
