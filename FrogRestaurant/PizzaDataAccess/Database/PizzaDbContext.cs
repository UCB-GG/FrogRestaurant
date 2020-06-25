using Microsoft.EntityFrameworkCore;

namespace PizzaDataAccess.Database
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<PizzaPersonTable> Persons { get; set; }
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaPersonTable>().HasData(
                       new PizzaPersonTable
                       {
                           Id = 1,
                           Name = "Цецо",
                       }
                   );

            modelBuilder.Entity<PizzaPersonTable>().HasData(
            new PizzaPersonTable
            {
                Id = 2,
                Name = "Мишо",
            });

            modelBuilder.Entity<PizzaPersonTable>().HasData(
            new PizzaPersonTable
            {
                Id = 3,
                Name = "Стелиан",
            }
            );

            //   modelBuilder.Entity<BusPersonTable>().Property(p => p.Id).UseOracleIdentityColumn();
        }
    }
}
