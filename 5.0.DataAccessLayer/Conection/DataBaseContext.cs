using _5._0.DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace _5._0.DataAccessLayer.Conection
{
    internal class DataBaseContext : DbContext
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
            String connection = "Server = 127.0.0.1; Database = dbAgenda20231; User Id = sa; Password = 1001";
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
