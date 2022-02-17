using Microsoft.EntityFrameworkCore;

namespace WiredBrainCoffeeAdmin.Data
{
    public class WiredBrainContext : DbContext
    {
        public WiredBrainContext(DbContextOptions options) : base(options) { }

        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Category = "Food",
                    Description = "This is a cupcake.",
                    Created = DateTime.Now,
                    ShortDescription = "Short",
                    ImgFileName = "cupcake.png",
                    Name = "Cup Cake",
                    Price = 5
                }
            );
        }
    }

}
