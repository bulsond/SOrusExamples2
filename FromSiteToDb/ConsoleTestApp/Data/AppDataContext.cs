using ConsoleTestApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleTestApp.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=cars.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
