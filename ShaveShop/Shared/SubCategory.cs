
namespace ShaveShop.Shared
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
