using Microsoft.EntityFrameworkCore;

namespace WiredBrainCoffeeAdmin.Data
{
    public class WiredBrainContext : DbContext
    {
        public WiredBrainContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                    {
                        Id = 1,
                        Name = "Charcuterie",
                        ShortDescription = "For indecisive food afficianados.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "charcuterie.jpg",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 2,
                        Name = "Waffles",
                        ShortDescription = "They need no introduction.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "waffles.jpg",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 3,
                        Name = "Santa Fe Salad",
                        ShortDescription = "Our house special - we love it.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "salad2.jpg",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 4,
                        Name = "Caesar Salad",
                        ShortDescription = "Classically, delicious fresh.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "salad1.jpg",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 5,
                        Name = "Noodles",
                        ShortDescription = "Delicious carbs on the go.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "noodles.png",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 6,
                        Name = "Red Velvet Cake",
                        ShortDescription = "Red Velvet...for those who prefer finer things.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "cake.jpg",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 7,
                        Name = "Cupcake",
                        ShortDescription = "Vanilla cupcakes with the perfect level of sweetness.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "cupcake.png",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 8,
                        Name = "Muffin",
                        ShortDescription = "A freshly baked chocolate chip muffin - the perfect way to start a Monday morning.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "muffin.png",
                        Price = 3,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 9,
                        Name = "Chocolate Bites",
                        ShortDescription = "Rich and sweet chocolate bites for those in need of a special treat.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "chocolate.png",
                        Price = 5,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 10,
                        Name = "Frosted Pumpkin Bread",
                        ShortDescription = "A seasonal delight we offer every autumn.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "pumpkinbread.png",
                        Price = 4,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 11,
                        Name = "Granola with Nuts",
                        ShortDescription = "It's not flashy, but it sure is healthy.  Perfect for when you need the calories, but not the guilt.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "granola.png",
                        Price = 3,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 12,
                        Name = "Chocolate Chip Cookies",
                        ShortDescription = "They're made fresh every day, and they taste like it..",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "cookies.png",
                        Price = 2,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 13,
                        Name = "Fresh Bagels",
                        ShortDescription = "They're just as round as donuts, but far more healthy! Freshly made every morning before sunrise.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "bagel.png",
                        Price = 5,
                        Category = "Food",
                    },
                    new Product()
                    {
                        Id = 14,
                        Name = "Dark Brewed Coffee",
                        ShortDescription = "A classic, refreshing original.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "ground.png",
                        Price = 2,
                        Category = "Coffee",
                    },
                    new Product()
                    {
                        Id = 15,
                        Name = "Latte",
                        ShortDescription = "More than just coffee, but still just coffee.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "cappucino.png",
                        Price = 3,
                        Category = "Coffee",
                    },
                    new Product()
                    {
                        Id = 16,
                        Name = "Americano",
                        ShortDescription = "Still classic, but a little more sophisticated.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "beans.jpg",
                        Price = 3.5M,
                        Category = "Coffee",
                    },
                    new Product()
                    {
                        Id = 18,
                        Name = "Designer Espresso",
                        ShortDescription = "Caffine has never looked so stunning.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "design.png",
                        Price = 6.5M,
                        Category = "Coffee",
                    },
                    new Product()
                    {
                        Id = 17,
                        Name = "Cappucino",
                        ShortDescription = "Rich and foamy, its the perfect comfort-coffee.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                        ImageFile = "cup.png",
                        Price = 4.5M,
                        Category = "Coffee",
                    }
            );
        }
    }

}
