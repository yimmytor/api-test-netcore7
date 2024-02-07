using Entities;

namespace ServiceContracts.DTO
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public CategoryResponse? Category { get; set; }
        public string? Sku { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<ProductImageResponse>? Images { get; set; }
        public List<string> Tags { get; set; }
    }

    public static class ProductExtensions
    {
        public static ProductResponse? ToProductResponse(this Product product)
        {
            if (product == null)
            {
                return null;
            }

            return new ProductResponse()
            {
                Id = product.Id,
                Category = product.Category.ToCategoryResponse(),
                Sku = product.Sku,
                Name = product.Name,
                Description = product.Description,
                Images = product.Images.Select(image => image.ToProductImageResponse()).ToList(),
                Tags = product.Tags
            };
        }
    }
}
