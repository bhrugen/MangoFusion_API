using MangoFusion_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangoFusion_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                Name = "Spring Roll",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/spring_roll.jpg",
                Price = 7.99,
                Category = "Appetizer",
                SpecialTag = ""
            },
            new MenuItem
            {
                Id = 2,
                Name = "Samosa",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/samosa.jpg",
                Price = 8.99,
                Category = "Appetizer",
                SpecialTag = ""
            },
            new MenuItem
            {
                Id = 3,
                Name = "Soup",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/soup.jpg",
                Price = 8.99,
                Category = "Appetizer",
                SpecialTag = "Best Seller"
            },
            new MenuItem
            {
                Id = 4,
                Name = "Noodles",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/noodles.jpg",
                Price = 10.99,
                Category = "Entrée",
                SpecialTag = ""
            },
            new MenuItem
            {
                Id = 5,
                Name = "Pav Bhaji",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/pav_bhaji.jpg",
                Price = 12.99,
                Category = "Entrée",
                SpecialTag = "Top Rated"
            },
            new MenuItem
            {
                Id = 6,
                Name = "Paneer Pizza",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/pizza.jpg",
                Price = 11.99,
                Category = "Entrée",
                SpecialTag = ""
            },
            new MenuItem
            {
                Id = 7,
                Name = "Mango Paradise",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/mango_paradise.jpg",
                Price = 13.99,
                Category = "Dessert",
                SpecialTag = "Chef's Special"
            },
            new MenuItem
            {
                Id = 8,
                Name = "Carrot Love",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/carrot_love.jpg",
                Price = 4.99,
                Category = "Dessert",
                SpecialTag = ""
            },
            new MenuItem
            {
                Id = 9,
                Name = "Sweet Rolls",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "images/sweet_rolls.jpg",
                Price = 4.99,
                Category = "Dessert",
                SpecialTag = "Chef's Special"
            });
        }
    }
}
