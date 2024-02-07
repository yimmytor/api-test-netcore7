using Entities;
using DataAccess;

namespace Business
{
    public static class ProductB
    {
        public static List<Product> GetAll()
        {
            return ProductDA.GetAll();
        }

        public static List<Product> SearchByText(string? searchtext)
        {
            return ProductDA.SearchByText(searchtext);
        }

        public static List<Product> SearchByCategory(int? categoryId)
        {
            return ProductDA.SearchByCategory(categoryId);
        }

        public static Product? GetById(int? productId)
        {
            return ProductDA.GetById(productId);
        }
    }
}
