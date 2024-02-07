using Entities;

namespace DataAccess
{
    public static class CategoryDA
    {
        private static readonly List<Category> _categoriesList = new()
        {
            new Category() { Id = 1, Name = "Electronics" },
            new Category() { Id = 2, Name = "Health and Wellness" },
            new Category() { Id = 3, Name = "Office Supplies" },
            new Category() { Id = 4, Name = "Home and Garden" },
            new Category() { Id = 5, Name = "Pet Supplies" },
            new Category() { Id = 6, Name = "Sports" }
        };

        public static List<Category> GetAll()
        {
            return _categoriesList;
        }

        public static Category? GetById(int? categoryId)
        {
            return _categoriesList
                   .Where(category => category.Id == categoryId)
                   .Select(category => category).ToList().FirstOrDefault();
        }
    }
}
