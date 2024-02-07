using Entities;

namespace ServiceContracts.DTO
{
    public class ProductImageResponse
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public int Type { get; set; }
    }

    public static class ProductImageExtensions
    {
        public static ProductImageResponse ToProductImageResponse(this ProductImage productImage)
        {
            return new ProductImageResponse()
            {
                Id = productImage.Id,
                Url = productImage.Url,
                Type = productImage.Type
            };
        }
    }
}
