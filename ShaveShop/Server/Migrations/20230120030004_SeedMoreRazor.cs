using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveShop.Server.Migrations
{
    public partial class SeedMoreRazor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "With this new straight razor, Boker closes the gap and offers a premium quality straight razor for an extremely affordable price - made in the Solingen, Germany facility. This straight razor is manufactured with a keen eye for each and every small detail. The popular shape of the razor is called \"King Cutter,\" also known as a \"Spanish point.\"", "https://www.shavershop.com/shop/images/th2_boker_3562.jpg", 189.00m, "Boker Straight Razor Edelweiss" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The White Ebony Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the White Ebony Wood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.", "https://www.shavershop.com/shop/images/th2_4200_dv_1155861_lg.jpg", 218.00m, "Dovo 5/8\" White Ebony Wood Handle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The handcrafted straight razor offers over 100 years of craftsmanship expertise. The high quality carbon steel, hollow ground blade is matched with a sleek stainless steel handle for a monotone metallic appearance. Due to the heavier weighting of the stainless steel handle, this straight razor best suited for a seasoned straight razor shaver.", "https://www.shavershop.com/shop/images/th2_4206_razor_98_lg.jpg", 340.00m, "Dovo 5/8\" Buffalo Horn Handle" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 1, "The Faux Tortoise Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the faux tortoise handle offers one of a kind comfort. This is an excellent blade for beginners.", "https://www.shavershop.com/shop/images/th2_4240_razor_515_lg.jpg", 175.00m, "Dovo 5/8 \" Faux Tortoise Handle" },
                    { 5, 1, "The Redwood Straight Razor is handcrafted and offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the redwood handle offers a one of a kind luxury scale. This is an excellent blade for beginners and experts alike.", "https://www.shavershop.com/shop/images/th2_4284_dovo_831_lg.jpg", 267.00m, "Dovo 5/8 \" Redwood Handle" },
                    { 6, 1, "Straight Bar with extra long handle. More comfortable for large hands, or just preference. Handle length 3-7/8\"", "https://www.shavershop.com/shop/images/th2_cc4225_long-handle_lg.jpg", 43.00m, "Merkur D E Safety Razor" },
                    { 7, 1, "This razor has an adjustable straight bar with 5 settings to insure the best shave for your skin and face. No Case.", "https://www.shavershop.com/shop/images/th2_7005_merkur_500-001_lg.jpg", 87.00m, "Merkur Progress Adjustable Razor" },
                    { 8, 1, "These Edwin Jagger Safety Razors are handcrafted and go through a special hard chrome process that is a beautiful and distinct \"blue chrome\" used by Rolls Royce. The chrome is truly distinctive when compared to the normal chrome we're all used to seeing. All Edwin Jagger razors and shaving brushes have superior fit, finish and quality not found in other brands.", "https://www.shavershop.com/shop/images/th2_de89l_jagger_chrome-lined_l.jpg", 41.00m, "Jagger Chrome Lined" },
                    { 9, 1, "This razor has 5 adjustable settings to insure the best shave for your skin and face. Straight Bar. Use Merkur Super Platinum or your Personal Favorite Double Edge Razor Blades", "https://www.shavershop.com/shop/images/th2_4239_merkur-510-001_lg.jpg", 97.00m, "Merkur Progress D E (Long Handle)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The handcrafted Ram's Horn Straight Razor by Thiers Issard of France, offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the rustic Ram's Horn handle offers a distinctive Old World style. The Thiers Issard Ram's Horn Straight Razor is an excellent blade for beginners and experts alike.", "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/563/896/00670535711476__83634.1630010155.png?c=1", 335.00m, "RAM HORN 5/8 BLADE STRAIGHT RAZOR" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The Horn Straight Razor handcrafted by Thiers Issard of France offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the Bovine* Horn handle offers a one of a kind luxury scale. The Thiers Issard Horn Straight Razor is an excellent blade for beginners and experts alike.", "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/567/1620/str_bovine_horn_5_8_blade__77767.1630010130.jpg?c=1", 320.99m, "Bovine Horn 5/8 Blade Straight Razor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The handcrafted straight razor by Thiers Issard of France offers over 100 years of craftsmanship expertise. The high quality carbon steel, hollow ground blade is matched with a sleek stainless steel handle for a monotone metallic appearance. Due to the heavier weighting of the stainless steel handle, this straight razor best suited for a seasoned straight razor shaver.", "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/566/1626/str_stainless_steel_5_8_blade__20887.1630010428.jpg?c=1", 195.99m, "Stainless Steel 5/8 Blade Straight Razor" });
        }
    }
}
