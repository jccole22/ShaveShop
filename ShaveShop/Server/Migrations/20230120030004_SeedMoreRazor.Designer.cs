// <auto-generated />
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
    [Migration("20230120030004_SeedMoreRazor")]
    partial class SeedMoreRazor
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
                            Title = "Dovo 5/8 \" Faux Tortoise Handle"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "The Redwood Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the redwood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.",
                            ImageUrl = "https://www.shavershop.com/shop/images/th2_4284_dovo_831_lg.jpg",
                            Price = 267.00m,
                            Title = "Dovo 5/8 \" Redwood Handle"
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
