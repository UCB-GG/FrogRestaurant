using Microsoft.EntityFrameworkCore;

namespace SoftDrinkDataAccess.Database
{
    public class SoftDrinkDbContext : DbContext
    {
        public DbSet<SoftDrinkPersonTable> SoftDrinkPersonTable { get; set; }

        public SoftDrinkDbContext(DbContextOptions<SoftDrinkDbContext> options) :
            base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoftDrinkPersonTable>().HasData(
           new SoftDrinkPersonTable
           {
               Id = 1,
               Name = "Toti",
           }
       );
            modelBuilder.Entity<SoftDrinkPersonTable>().HasData(
            new SoftDrinkPersonTable
            {
                Id = 2,
                Name = "Leo",
            });

            modelBuilder.Entity<SoftDrinkPersonTable>().HasData(
            new SoftDrinkPersonTable
            {
                Id = 3,
                Name = "Zerroni",
            }
            );
            //  modelBuilder.Entity<PersonTable>().Property(p => p.Id).UseOracleIdentityColumn();
        }
    }
}
