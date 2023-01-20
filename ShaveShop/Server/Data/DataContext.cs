using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System;

namespace ShaveShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id=1,
                    Name="Razors",
                    Url="razors"
                },
                new Category
                {
                    Id = 2,
                    Name ="Brushes",
                    Url ="brushes"
                }, new Category
                {
                    Id = 3,
                    Name ="Creams & Soaps",
                    Url ="creams-soaps"
                }, new Category
                {
                    Id = 4,
                    Name = "After Shave",
                    Url = "after-shave"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Boker Straight Razor Edelweiss",
                        Description = "With this new straight razor, Boker closes the gap and offers a premium quality straight razor for an extremely affordable price - made in the Solingen, Germany facility. This straight razor is manufactured with a keen eye for each and every small detail. The popular shape of the razor is called \"King Cutter,\" also known as a \"Spanish point.\"",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_boker_3562.jpg",
                        Price = 189.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Dovo 5/8\" White Ebony Wood Handle",
                        Description = "The White Ebony Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the White Ebony Wood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4200_dv_1155861_lg.jpg",
                        Price = 218.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Dovo 5/8\" Buffalo Horn Handle",
                        Description = "The handcrafted straight razor offers over 100 years of craftsmanship expertise. The high quality carbon steel, hollow ground blade is matched with a sleek stainless steel handle for a monotone metallic appearance. Due to the heavier weighting of the stainless steel handle, this straight razor best suited for a seasoned straight razor shaver.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4206_razor_98_lg.jpg",
                        Price = 340.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Dovo 5/8 \" Faux Tortoise Handle",
                        Description = "The Faux Tortoise Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the faux tortoise handle offers one of a kind comfort. This is an excellent blade for beginners.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4240_razor_515_lg.jpg",
                        Price = 175.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Dovo 5/8 \" Redwood Handle",
                        Description = "The Redwood Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the redwood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4284_dovo_831_lg.jpg",
                        Price = 267.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Merkur D E Safety Razor",
                        Description = "Straight Bar with extra long handle. More comfortable for large hands, or just preference. Handle length 3-7/8\"",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_cc4225_long-handle_lg.jpg",
                        Price = 43.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Merkur Progress Adjustable Razor",
                        Description = "This razor has an adjustable straight bar with 5 settings to insure the best shave for your skin and face. No Case.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_7005_merkur_500-001_lg.jpg",
                        Price = 87.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Jagger Chrome Lined",
                        Description = "These Edwin Jagger Safety Razors are handcrafted and go through a special hard chrome process that is a beautiful and distinct \"blue chrome\" used by Rolls Royce. The chrome is truly distinctive when compared to the normal chrome we're all used to seeing. All Edwin Jagger razors and shaving brushes have superior fit, finish and quality not found in other brands.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_de89l_jagger_chrome-lined_l.jpg",
                        Price = 41.00m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "Merkur Progress D E (Long Handle)",
                        Description = "This razor has 5 adjustable settings to insure the best shave for your skin and face. Straight Bar. Use Merkur Super Platinum or your Personal Favorite Double Edge Razor Blades",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4239_merkur-510-001_lg.jpg",
                        Price = 97.00m,
                        CategoryId = 1
                    }
                );
        }

        //this creates a database for products
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
