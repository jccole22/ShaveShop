using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveShop.Server.Migrations
{
    public partial class SeedNewProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Dovo 5/8\" Faux Tortoise Handle");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Dovo 5/8\" Redwood Handle");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 10, 2, "This is a fantastic starter brush has you get introduced to wet shaving, lathering, and the wonderful properties of badger hair. Badger has long been the choice for wet shavers because of its water retention, backbone, and face feel. It whips up phenomenal lathers. While it comes in numerous-grades\", badger hair called-pure\" is a great option for the beginner as it won't break the bank, like the more expensive-silvertips\". A 24mm knot makes this a medium (trending to large) brush that creates ample lather. The densely-packed knot is set deep in the handle for durability and comfort.", "https://www.shavershop.com/shop/images/th2_4300.jpg", 30.00m, "C. Conk Pure Badger Shave Brush" },
                    { 11, 2, "This natural fiber is most prized by shaving aficionados as it has good backbone and water retention to help you whip up a fabulous lather. And silvertip hair is some of the best. These hairs are the highest quality badger- soft to the touch with a great face feel. The 24mm knot is a lather monster with a densely-packed large head to produce your lubricant. And we've set the knot deep in the handle for durability and comfort.", "https://www.shavershop.com/shop/images/th2_9904_whst.jpg", 65.00m, "Parker Faux Petrified Wood Handle - Silvertip Badger Brush" },
                    { 12, 2, "This brush is loaded with Parker's banded pure boar bristles. Boar is known for its stiffness - great for those seeking exfoliation and the \"scritchy\" feeling on your face. It is also an effective latherer, whipping up mounds of white froth. It is great on creams or soaps. This brush will soften over time to give you softer bristles - rather like wearing in a nice pair of leather shoes.", "https://www.shavershop.com/shop/images/th2_9937_blbo.jpg", 17.00m, "Parker Blue Wood Handle – Boar Bristle Brush" },
                    { 13, 2, "Parker is well known for their boar brushes and this is one of the finest on the market. The bristle and handle are the top of Parker's product line and sure to exceed your expectations. The handle is a very functional, fitting well within a variety of hand sizes and give the brush a little extra length to avoid lather on your fingers.", "https://www.shavershop.com/shop/images/th2_9939_rwbo.jpg", 17.00m, "Parker Rosewood Handle - Boar Bristle Brush" },
                    { 14, 2, "This brush is one of the heaviest ones we have ever handled. The unique chrome handle has a very solid, weighty feel to it and is quite cool to the touch. The distinctly soft and dense bristles lofted together create a luxurious lather that you are sure to enjoy.", "https://www.shavershop.com/shop/images/th2_9938_chpb.jpg", 42.00m, "Parker Chrome Handle - Pure Badger Brush" },
                    { 15, 3, "Taylor of Old Bond Street Sandalwood Shaving Cream - Tub. In the traditional method, the cream is placed on the brush or on the palm and then applied to the face, where the brush is used to work up a lather.  However, most today prefer to use a lather \"bowl\".  Whichever method you chose, you'll be amazed how well theses creams prepare your beard and moisturize your face. From the mystic east, we take a complex rich woody blend of exotic sweet scented Sandalwood and Cedar, add Lavender and Rosemary with subtle floral and Jasmine and Rose, for a vivacious, enticing, confidently masculine bouquet ", "https://www.shavershop.com/shop/images/th2_3400_sandlewood.jpg", 19.98m, "Taylor Sandalwood Shaving Cream" },
                    { 16, 3, "This shaving soap is a glycerin-based one and it uses avocado oil and Tocopherol Acetate to provide great lubrication and conditioning. This manufacturer makes the same thing in a lot of different shaving soap varieties, so it's well worth it to take a look at what they have if you like how this performs. Amber is a timeless scent, combining a very relaxed, refined sort of character with a fresh outdoorsy element, as well. It's warm and fresh at the same time and anybody who gets close enough to get a whiff of it is going to know that you're a distinguished fellow.", "https://www.shavershop.com/shop/images/th2_4227_123.jpg", 5.90m, "C. Conk Amber Super Bar Shave Soap" },
                    { 17, 3, "Trumper Almond Hard Soap in Wooden Bowl. Supplied in a hand-turned wooden bowl, this fine quality Almond Hard Shaving Soap is specially formulated using essential oils to give a smooth shave leaving the skin soft.", "https://www.shavershop.com/shop/images/th2_7704.jpg", 36.00m, "Trumper Almond Hard Shaving Soap" },
                    { 18, 3, "Santa Fe Cedar - Robust Cedar and Rosemary. Rich, silky and luxurious shave cream, a great alternative to our new natural shave soap. Provides a premium shave and leaves skin feeling nourished and refreshed. Made with natural ingredients, scented by exclusive blends of essential oils. 5.5oz.", "https://www.shavershop.com/shop/images/th2_1311-4331-c.jpg", 16.00m, "C. Conk Santa Fe Cedar Shave Cream" },
                    { 19, 4, "Bursting with top notes of orange, bergamot and mouth-watering lemon with green nuances throughout. The floral heart of jasmine, orange flower and geranium dance with lavender and is completed with a warm musk background.", "https://www.shavershop.com/shop/images/th2_6456_aftershave_700.jpg", 8.95m, "Clubman After Shave Lotion" },
                    { 20, 4, "This bay rum aftershave comes in a 4-ounce bottle and that will give you plenty to use. Just as the name says, the scent of this is evocative of a tropical island, with bay leaves and Jamaican rum used as the primary fragrance ingredients. This is very high quality, and you will smell really good. This is one of those aromas that, for some guys, fits them in a way that nothing else can. It's also a classic, so most people appreciate it.This will tone your skin, close up your pores and help you avoid getting razor rash and other issues after you shave and its scent will last a little longer than a typical aftershave.", "https://www.shavershop.com/shop/images/th2_4253_conk_144.jpg", 19.50m, "C. Conk Bay Rum Aftershave Cologne" },
                    { 21, 4, "Trumper's Aftershave comes in a frosted glass bottle with our crown stopper. Ylang ylang, geranium bourbon, neroli, rosmary, and a hint of musk are just five of the eleven essences that give the Skye Aftershave its distinctive bouquet.", "https://www.shavershop.com/shop/images/th2_7726.jpg", 55.00m, "Trumper Skye Aftershave" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Dovo 5/8 \" Faux Tortoise Handle");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Dovo 5/8 \" Redwood Handle");
        }
    }
}
