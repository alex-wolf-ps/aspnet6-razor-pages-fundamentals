using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WiredBrainCoffeeAdmin.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFile = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "charcuterie.jpg", "Charcuterie", 4m, "For indecisive food afficianados." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "waffles.jpg", "Waffles", 4m, "They need no introduction." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "salad2.jpg", "Santa Fe Salad", 4m, "Our house special - we love it." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 4, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "salad1.jpg", "Caesar Salad", 4m, "Classically, delicious fresh." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 5, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "noodles.png", "Noodles", 4m, "Delicious carbs on the go." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 6, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "cake.jpg", "Red Velvet Cake", 4m, "Red Velvet...for those who prefer finer things." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 7, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "cupcake.png", "Cupcake", 4m, "Vanilla cupcakes with the perfect level of sweetness." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 8, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "muffin.png", "Muffin", 3m, "A freshly baked chocolate chip muffin - the perfect way to start a Monday morning." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 9, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "chocolate.png", "Chocolate Bites", 5m, "Rich and sweet chocolate bites for those in need of a special treat." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 10, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "pumpkinbread.png", "Frosted Pumpkin Bread", 4m, "A seasonal delight we offer every autumn." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 11, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "granola.png", "Granola with Nuts", 3m, "It's not flashy, but it sure is healthy.  Perfect for when you need the calories, but not the guilt." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 12, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "cookies.png", "Chocolate Chip Cookies", 2m, "They're made fresh every day, and they taste like it.." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 13, "Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "bagel.png", "Fresh Bagels", 5m, "They're just as round as donuts, but far more healthy! Freshly made every morning before sunrise." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 14, "Coffee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "ground.png", "Dark Brewed Coffee", 2m, "A classic, refreshing original." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 15, "Coffee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "cappucino.png", "Latte", 3m, "More than just coffee, but still just coffee." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 16, "Coffee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "beans.jpg", "Americano", 3.5m, "Still classic, but a little more sophisticated." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 17, "Coffee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "cup.png", "Cappucino", 4.5m, "Rich and foamy, its the perfect comfort-coffee." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShortDescription" },
                values: new object[] { 18, "Coffee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.", "design.png", "Designer Espresso", 6.5m, "Caffine has never looked so stunning." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
