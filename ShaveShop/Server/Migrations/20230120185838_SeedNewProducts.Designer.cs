﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShaveShop.Server.Data;

#nullable disable

namespace ShaveShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230120185838_SeedNewProducts")]
    partial class SeedNewProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShaveShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Razors",
                            Url = "razors"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Brushes",
                            Url = "brushes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Creams & Soaps",
                            Url = "creams-soaps"
                        },
                        new
                        {
                            Id = 4,
                            Name = "After Shave",
                            Url = "after-shave"
                        });
                });

            modelBuilder.Entity("ShaveShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "With this new straight razor, Boker closes the gap and offers a premium quality straight razor for an extremely affordable price - made in the Solingen, Germany facility. This straight razor is manufactured with a keen eye for each and every small detail. The popular shape of the razor is called \"King Cutter,\" also known as a \"Spanish point.\"",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_boker_3562.jpg",
                            Price = 189.00m,
                            Title = "Boker Straight Razor Edelweiss"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "The White Ebony Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the White Ebony Wood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4200_dv_1155861_lg.jpg",
                            Price = 218.00m,
                            Title = "Dovo 5/8\" White Ebony Wood Handle"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "The handcrafted straight razor offers over 100 years of craftsmanship expertise. The high quality carbon steel, hollow ground blade is matched with a sleek stainless steel handle for a monotone metallic appearance. Due to the heavier weighting of the stainless steel handle, this straight razor best suited for a seasoned straight razor shaver.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4206_razor_98_lg.jpg",
                            Price = 340.00m,
                            Title = "Dovo 5/8\" Buffalo Horn Handle"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "The Faux Tortoise Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the faux tortoise handle offers one of a kind comfort. This is an excellent blade for beginners.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4240_razor_515_lg.jpg",
                            Price = 175.00m,
                            Title = "Dovo 5/8\" Faux Tortoise Handle"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "The Redwood Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the redwood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4284_dovo_831_lg.jpg",
                            Price = 267.00m,
                            Title = "Dovo 5/8\" Redwood Handle"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Straight Bar with extra long handle. More comfortable for large hands, or just preference. Handle length 3-7/8\"",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_cc4225_long-handle_lg.jpg",
                            Price = 43.00m,
                            Title = "Merkur D E Safety Razor"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "This razor has an adjustable straight bar with 5 settings to insure the best shave for your skin and face. No Case.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_7005_merkur_500-001_lg.jpg",
                            Price = 87.00m,
                            Title = "Merkur Progress Adjustable Razor"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "These Edwin Jagger Safety Razors are handcrafted and go through a special hard chrome process that is a beautiful and distinct \"blue chrome\" used by Rolls Royce. The chrome is truly distinctive when compared to the normal chrome we're all used to seeing. All Edwin Jagger razors and shaving brushes have superior fit, finish and quality not found in other brands.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_de89l_jagger_chrome-lined_l.jpg",
                            Price = 41.00m,
                            Title = "Jagger Chrome Lined"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "This razor has 5 adjustable settings to insure the best shave for your skin and face. Straight Bar. Use Merkur Super Platinum or your Personal Favorite Double Edge Razor Blades",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4239_merkur-510-001_lg.jpg",
                            Price = 97.00m,
                            Title = "Merkur Progress D E (Long Handle)"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "This is a fantastic starter brush has you get introduced to wet shaving, lathering, and the wonderful properties of badger hair. Badger has long been the choice for wet shavers because of its water retention, backbone, and face feel. It whips up phenomenal lathers. While it comes in numerous-grades\", badger hair called-pure\" is a great option for the beginner as it won't break the bank, like the more expensive-silvertips\". A 24mm knot makes this a medium (trending to large) brush that creates ample lather. The densely-packed knot is set deep in the handle for durability and comfort.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4300.jpg",
                            Price = 30.00m,
                            Title = "C. Conk Pure Badger Shave Brush"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "This natural fiber is most prized by shaving aficionados as it has good backbone and water retention to help you whip up a fabulous lather. And silvertip hair is some of the best. These hairs are the highest quality badger- soft to the touch with a great face feel. The 24mm knot is a lather monster with a densely-packed large head to produce your lubricant. And we've set the knot deep in the handle for durability and comfort.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_9904_whst.jpg",
                            Price = 65.00m,
                            Title = "Parker Faux Petrified Wood Handle - Silvertip Badger Brush"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "This brush is loaded with Parker's banded pure boar bristles. Boar is known for its stiffness - great for those seeking exfoliation and the \"scritchy\" feeling on your face. It is also an effective latherer, whipping up mounds of white froth. It is great on creams or soaps. This brush will soften over time to give you softer bristles - rather like wearing in a nice pair of leather shoes.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_9937_blbo.jpg",
                            Price = 17.00m,
                            Title = "Parker Blue Wood Handle – Boar Bristle Brush"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Parker is well known for their boar brushes and this is one of the finest on the market. The bristle and handle are the top of Parker's product line and sure to exceed your expectations. The handle is a very functional, fitting well within a variety of hand sizes and give the brush a little extra length to avoid lather on your fingers.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_9939_rwbo.jpg",
                            Price = 17.00m,
                            Title = "Parker Rosewood Handle - Boar Bristle Brush"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "This brush is one of the heaviest ones we have ever handled. The unique chrome handle has a very solid, weighty feel to it and is quite cool to the touch. The distinctly soft and dense bristles lofted together create a luxurious lather that you are sure to enjoy.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_9938_chpb.jpg",
                            Price = 42.00m,
                            Title = "Parker Chrome Handle - Pure Badger Brush"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Taylor of Old Bond Street Sandalwood Shaving Cream - Tub. In the traditional method, the cream is placed on the brush or on the palm and then applied to the face, where the brush is used to work up a lather.  However, most today prefer to use a lather \"bowl\".  Whichever method you chose, you'll be amazed how well theses creams prepare your beard and moisturize your face. From the mystic east, we take a complex rich woody blend of exotic sweet scented Sandalwood and Cedar, add Lavender and Rosemary with subtle floral and Jasmine and Rose, for a vivacious, enticing, confidently masculine bouquet ",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_3400_sandlewood.jpg",
                            Price = 19.98m,
                            Title = "Taylor Sandalwood Shaving Cream"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "This shaving soap is a glycerin-based one and it uses avocado oil and Tocopherol Acetate to provide great lubrication and conditioning. This manufacturer makes the same thing in a lot of different shaving soap varieties, so it's well worth it to take a look at what they have if you like how this performs. Amber is a timeless scent, combining a very relaxed, refined sort of character with a fresh outdoorsy element, as well. It's warm and fresh at the same time and anybody who gets close enough to get a whiff of it is going to know that you're a distinguished fellow.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4227_123.jpg",
                            Price = 5.90m,
                            Title = "C. Conk Amber Super Bar Shave Soap"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Description = "Trumper Almond Hard Soap in Wooden Bowl. Supplied in a hand-turned wooden bowl, this fine quality Almond Hard Shaving Soap is specially formulated using essential oils to give a smooth shave leaving the skin soft.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_7704.jpg",
                            Price = 36.00m,
                            Title = "Trumper Almond Hard Shaving Soap"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Santa Fe Cedar - Robust Cedar and Rosemary. Rich, silky and luxurious shave cream, a great alternative to our new natural shave soap. Provides a premium shave and leaves skin feeling nourished and refreshed. Made with natural ingredients, scented by exclusive blends of essential oils. 5.5oz.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_1311-4331-c.jpg",
                            Price = 16.00m,
                            Title = "C. Conk Santa Fe Cedar Shave Cream"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Bursting with top notes of orange, bergamot and mouth-watering lemon with green nuances throughout. The floral heart of jasmine, orange flower and geranium dance with lavender and is completed with a warm musk background.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_6456_aftershave_700.jpg",
                            Price = 8.95m,
                            Title = "Clubman After Shave Lotion"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "This bay rum aftershave comes in a 4-ounce bottle and that will give you plenty to use. Just as the name says, the scent of this is evocative of a tropical island, with bay leaves and Jamaican rum used as the primary fragrance ingredients. This is very high quality, and you will smell really good. This is one of those aromas that, for some guys, fits them in a way that nothing else can. It's also a classic, so most people appreciate it.This will tone your skin, close up your pores and help you avoid getting razor rash and other issues after you shave and its scent will last a little longer than a typical aftershave.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4253_conk_144.jpg",
                            Price = 19.50m,
                            Title = "C. Conk Bay Rum Aftershave Cologne"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Trumper's Aftershave comes in a frosted glass bottle with our crown stopper. Ylang ylang, geranium bourbon, neroli, rosmary, and a hint of musk are just five of the eleven essences that give the Skye Aftershave its distinctive bouquet.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_7726.jpg",
                            Price = 55.00m,
                            Title = "Trumper Skye Aftershave"
                        });
                });

            modelBuilder.Entity("ShaveShop.Shared.Product", b =>
                {
                    b.HasOne("ShaveShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
