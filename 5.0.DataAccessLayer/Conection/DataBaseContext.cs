using _5._0.DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace _5._0.DataAccessLayer.Conection
{
    public class DataBaseContext : DbContext
    {
        //Declarando las DBC
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("tcity");
            modelBuilder.Entity<User>().ToTable("tuser");
            modelBuilder.Entity<Person>().ToTable("tperson");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer("Server=Acer\\SQLEXPRESS; Database=dbAgenda20231; Trusted_Connection=True; TrustServerCertificate=True");
                Console.WriteLine("Connection TRUE");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
