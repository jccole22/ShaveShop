using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveShop.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "The handcrafted Ram's Horn Straight Razor by Thiers Issard of France, offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the rustic Ram's Horn handle offers a distinctive Old World style. The Thiers Issard Ram's Horn Straight Razor is an excellent blade for beginners and experts alike.", "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/563/896/00670535711476__83634.1630010155.png?c=1", 335.00m, "RAM HORN 5/8 BLADE STRAIGHT RAZOR" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The Horn Straight Razor handcrafted by Thiers Issard of France offers over 100 years of craftsmanship expertise. The high quality carbon steel blade delivers a clean, close cut. While the Bovine* Horn handle offers a one of a kind luxury scale. The Thiers Issard Horn Straight Razor is an excellent blade for beginners and experts alike.", "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/567/1620/str_bovine_horn_5_8_blade__77767.1630010130.jpg?c=1", 320.99m, "Bovine Horn 5/8 Blade Straight Razor" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "The handcrafted straight razor by Thiers Issard of France offers over 100 years of craftsmanship expertise. The high quality carbon steel, hollow ground blade is matched with a sleek stainless steel handle for a monotone metallic appearance. Due to the heavier weighting of the stainless steel handle, this straight razor best suited for a seasoned straight razor shaver.", "https://cdn11.bigcommerce.com/s-iq1w68t3mw/images/stencil/320w/products/566/1626/str_stainless_steel_5_8_blade__20887.1630010428.jpg?c=1", 195.99m, "Stainless Steel 5/8 Blade Straight Razor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
