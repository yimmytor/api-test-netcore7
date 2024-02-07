namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public Category? Category { get; set; }
        public string? Sku { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<ProductImage>? Images { get; set; }
        public List<string>? Tags { get; set; }
    }
}
