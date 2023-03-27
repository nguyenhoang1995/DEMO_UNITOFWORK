using Microsoft.EntityFrameworkCore;

namespace DEMO_UNITOFWORK.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().ToTable("Orders").HasKey(p => p.Id);
            modelBuilder.Entity<Product>().ToTable("Products").HasKey(u => u.Id);

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }



    }
}
