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
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory
                {
                    Id = 1,
                    Name = "Straight Razors",
                    Url = "straight-razors"
                },
                new SubCategory
                {
                    Id = 2,
                    Name = "Safety Razors",
                    Url = "safety-razors"
                },
                new SubCategory
                {
                    Id = 3,
                    Name = "Badger Brushes",
                    Url = "badger-brushes"
                },
                new SubCategory
                {
                    Id = 4,
                    Name = "Boar Brushes",
                    Url = "boar-brushes"
                },
                new SubCategory
                {
                    Id = 5,
                    Name = "Shaving Creams",
                    Url = "shaving-creams"
                },
                new SubCategory
                {
                    Id = 6,
                    Name = "Shaving Soaps",
                    Url = "shaving-soaps"
                },
                new SubCategory
                {
                    Id = 7,
                    Name = "Colognes",
                    Url = "colognes"
                },
                new SubCategory
                {
                    Id = 8,
                    Name = "Lotions",
                    Url = "lotions"
                }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Razors",
                    Url = "razors"
                },
                new Category
                {
                    Id = 2,
                    Name = "Brushes",
                    Url = "brushes"
                }, new Category
                {
                    Id = 3,
                    Name = "Creams & Soaps",
                    Url = "creams-soaps"
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
                        CategoryId = 1,
                        SubCategoryId = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Dovo 5/8\" White Ebony Wood Handle",
                        Description = "The White Ebony Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the White Ebony Wood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4200_dv_1155861_lg.jpg",
                        Price = 218.00m,
                        CategoryId = 1,
                        SubCategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Dovo 5/8\" Buffalo Horn Handle",
                        Description = "The handcrafted straight razor offers over 100 years of craftsmanship expertise. The high quality carbon steel, hollow ground blade is matched with a sleek stainless steel handle for a monotone metallic appearance. Due to the heavier weighting of the stainless steel handle, this straight razor best suited for a seasoned straight razor shaver.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4206_razor_98_lg.jpg",
                        Price = 340.00m,
                        CategoryId = 1,
                        SubCategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Dovo 5/8\" Faux Tortoise Handle",
                        Description = "The Faux Tortoise Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the faux tortoise handle offers one of a kind comfort. This is an excellent blade for beginners.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4240_razor_515_lg.jpg",
                        Price = 175.00m,
                        CategoryId = 1,
                        SubCategoryId = 1
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Dovo 5/8\" Redwood Handle",
                        Description = "The Redwood Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the redwood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4284_dovo_831_lg.jpg",
                        Price = 267.00m,
                        CategoryId = 1,
                        SubCategoryId = 1
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Merkur D E Safety Razor",
                        Description = "Straight Bar with extra long handle. More comfortable for large hands, or just preference. Handle length 3-7/8\"",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_cc4225_long-handle_lg.jpg",
                        Price = 43.00m,
                        CategoryId = 1,
                        SubCategoryId = 2
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Merkur Progress Adjustable Razor",
                        Description = "This razor has an adjustable straight bar with 5 settings to insure the best shave for your skin and face. No Case.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_7005_merkur_500-001_lg.jpg",
                        Price = 87.00m,
                        CategoryId = 1,
                        SubCategoryId = 2
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Jagger Chrome Lined",
                        Description = "These Edwin Jagger Safety Razors are handcrafted and go through a special hard chrome process that is a beautiful and distinct \"blue chrome\" used by Rolls Royce. The chrome is truly distinctive when compared to the normal chrome we're all used to seeing. All Edwin Jagger razors and shaving brushes have superior fit, finish and quality not found in other brands.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_de89l_jagger_chrome-lined_l.jpg",
                        Price = 41.00m,
                        CategoryId = 1,
                        SubCategoryId = 2
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "Merkur Progress D E (Long Handle)",
                        Description = "This razor has 5 adjustable settings to insure the best shave for your skin and face. Straight Bar. Use Merkur Super Platinum or your Personal Favorite Double Edge Razor Blades",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4239_merkur-510-001_lg.jpg",
                        Price = 97.00m,
                        CategoryId = 1,
                        SubCategoryId = 2
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "C. Conk Pure Badger Shave Brush",
                        Description = "This is a fantastic starter brush has you get introduced to wet shaving, lathering, and the wonderful properties of badger hair. Badger has long been the choice for wet shavers because of its water retention, backbone, and face feel. It whips up phenomenal lathers. While it comes in numerous-grades\", badger hair called-pure\" is a great option for the beginner as it won't break the bank, like the more expensive-silvertips\". A 24mm knot makes this a medium (trending to large) brush that creates ample lather. The densely-packed knot is set deep in the handle for durability and comfort.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4300.jpg",
                        Price = 30.00m,
                        CategoryId = 2,
                        SubCategoryId = 3
                    },
                    new Product
                    {
                        Id = 11,
                        Title = "Parker Faux Petrified Wood Handle - Silvertip Badger Brush",
                        Description = "This natural fiber is most prized by shaving aficionados as it has good backbone and water retention to help you whip up a fabulous lather. And silvertip hair is some of the best. These hairs are the highest quality badger- soft to the touch with a great face feel. The 24mm knot is a lather monster with a densely-packed large head to produce your lubricant. And we've set the knot deep in the handle for durability and comfort.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_9904_whst.jpg",
                        Price = 65.00m,
                        CategoryId = 2,
                        SubCategoryId = 3
                    },
                    new Product
                    {
                        Id = 12,
                        Title = "Parker Blue Wood Handle – Boar Bristle Brush",
                        Description = "This brush is loaded with Parker's banded pure boar bristles. Boar is known for its stiffness - great for those seeking exfoliation and the \"scritchy\" feeling on your face. It is also an effective latherer, whipping up mounds of white froth. It is great on creams or soaps. This brush will soften over time to give you softer bristles - rather like wearing in a nice pair of leather shoes.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_9937_blbo.jpg",
                        Price = 17.00m,
                        CategoryId = 2,
                        SubCategoryId = 4
                    },
                    new Product
                    {
                        Id = 13,
                        Title = "Parker Rosewood Handle - Boar Bristle Brush",
                        Description = "Parker is well known for their boar brushes and this is one of the finest on the market. The bristle and handle are the top of Parker's product line and sure to exceed your expectations. The handle is a very functional, fitting well within a variety of hand sizes and give the brush a little extra length to avoid lather on your fingers.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_9939_rwbo.jpg",
                        Price = 17.00m,
                        CategoryId = 2,
                        SubCategoryId = 4
                    },
                    new Product
                    {
                        Id = 14,
                        Title = "Parker Chrome Handle - Pure Badger Brush",
                        Description = "This brush is one of the heaviest ones we have ever handled. The unique chrome handle has a very solid, weighty feel to it and is quite cool to the touch. The distinctly soft and dense bristles lofted together create a luxurious lather that you are sure to enjoy.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_9938_chpb.jpg",
                        Price = 42.00m,
                        CategoryId = 2,
                        SubCategoryId = 3
                    },
                    new Product
                    {
                        Id = 15,
                        Title = "Taylor Sandalwood Shaving Cream",
                        Description = "Taylor of Old Bond Street Sandalwood Shaving Cream - Tub. In the traditional method, the cream is placed on the brush or on the palm and then applied to the face, where the brush is used to work up a lather.  However, most today prefer to use a lather \"bowl\".  Whichever method you chose, you'll be amazed how well theses creams prepare your beard and moisturize your face. From the mystic east, we take a complex rich woody blend of exotic sweet scented Sandalwood and Cedar, add Lavender and Rosemary with subtle floral and Jasmine and Rose, for a vivacious, enticing, confidently masculine bouquet ",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_3400_sandlewood.jpg",
                        Price = 19.98m,
                        CategoryId = 3,
                        SubCategoryId = 5
                    },
                    new Product
                    {
                        Id = 16,
                        Title = "C. Conk Amber Super Bar Shave Soap",
                        Description = "This shaving soap is a glycerin-based one and it uses avocado oil and Tocopherol Acetate to provide great lubrication and conditioning. This manufacturer makes the same thing in a lot of different shaving soap varieties, so it's well worth it to take a look at what they have if you like how this performs. Amber is a timeless scent, combining a very relaxed, refined sort of character with a fresh outdoorsy element, as well. It's warm and fresh at the same time and anybody who gets close enough to get a whiff of it is going to know that you're a distinguished fellow.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4227_123.jpg",
                        Price = 5.90m,
                        CategoryId = 3,
                        SubCategoryId = 6
                    },
                    new Product
                    {
                        Id = 17,
                        Title = "Trumper Almond Hard Shaving Soap",
                        Description = "Trumper Almond Hard Soap in Wooden Bowl. Supplied in a hand-turned wooden bowl, this fine quality Almond Hard Shaving Soap is specially formulated using essential oils to give a smooth shave leaving the skin soft.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_7704.jpg",
                        Price = 36.00m,
                        CategoryId = 3,
                        SubCategoryId = 6
                    },
                    new Product
                    {
                        Id = 18,
                        Title = "C. Conk Santa Fe Cedar Shave Cream",
                        Description = "Santa Fe Cedar - Robust Cedar and Rosemary. Rich, silky and luxurious shave cream, a great alternative to our new natural shave soap. Provides a premium shave and leaves skin feeling nourished and refreshed. Made with natural ingredients, scented by exclusive blends of essential oils. 5.5oz.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_1311-4331-c.jpg",
                        Price = 16.00m,
                        CategoryId = 3,
                        SubCategoryId = 5
                    },
                    new Product
                    {
                        Id = 19,
                        Title = "Clubman After Shave Lotion",
                        Description = "Bursting with top notes of orange, bergamot and mouth-watering lemon with green nuances throughout. The floral heart of jasmine, orange flower and geranium dance with lavender and is completed with a warm musk background.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_6456_aftershave_700.jpg",
                        Price = 8.95m,
                        CategoryId = 4,
                        SubCategoryId = 8
                    },
                    new Product
                    {
                        Id = 20,
                        Title = "C. Conk Bay Rum Aftershave Cologne",
                        Description = "This bay rum aftershave comes in a 4-ounce bottle and that will give you plenty to use. Just as the name says, the scent of this is evocative of a tropical island, with bay leaves and Jamaican rum used as the primary fragrance ingredients. This is very high quality, and you will smell really good. This is one of those aromas that, for some guys, fits them in a way that nothing else can. It's also a classic, so most people appreciate it.This will tone your skin, close up your pores and help you avoid getting razor rash and other issues after you shave and its scent will last a little longer than a typical aftershave.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_4253_conk_144.jpg",
                        Price = 19.50m,
                        CategoryId = 4,
                        SubCategoryId = 7
                    },
                    new Product
                    {
                        Id = 21,
                        Title = "Trumper Skye Aftershave",
                        Description = "Trumper's Aftershave comes in a frosted glass bottle with our crown stopper. Ylang ylang, geranium bourbon, neroli, rosmary, and a hint of musk are just five of the eleven essences that give the Skye Aftershave its distinctive bouquet.",
                        ImageUrl = "https://www.shavershop.com/shop/images/th2_7726.jpg",
                        Price = 55.00m,
                        CategoryId = 4,
                        SubCategoryId = 7
                    }
                );
        }

        //this creates a database for products
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}
