using Entities;
using Business;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class CategoriesService : ICategoriesService
    {
        private CategoryResponse ConvertToResponse(Category category)
        {
            CategoryResponse categoryResponse = category.ToCategoryResponse();

            return categoryResponse;
        }

        public List<CategoryResponse> GetAll()
        {
            return CategoryB.GetAll().Select(category => ConvertToResponse(category)).ToList();
        }

        public CategoryResponse? GetById(int? categoryId)
        {
            if (categoryId == 0 || categoryId == null)
            {
                return null;
            }

            return CategoryB.GetById(categoryId).ToCategoryResponse();
        }
    }
}
