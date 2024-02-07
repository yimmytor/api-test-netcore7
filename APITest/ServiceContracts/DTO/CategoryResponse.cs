using Entities;

namespace ServiceContracts.DTO
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public static class CategoryExtensions
    {
        public static CategoryResponse? ToCategoryResponse(this Category category)
        {
            if (category == null)
            {
                return null;
            }

            return new CategoryResponse()
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
