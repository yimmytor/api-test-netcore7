using Entities;
using DataAccess;

namespace Business
{
    public static class CategoryB
    {
        public static List<Category> GetAll()
        {
            return CategoryDA.GetAll();
        }

        public static Category? GetById(int? categoryId)
        {
            return CategoryDA.GetById(categoryId);
        }
    }
}
