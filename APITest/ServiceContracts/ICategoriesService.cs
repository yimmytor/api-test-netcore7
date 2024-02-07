using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface ICategoriesService
    {
        List<CategoryResponse> GetAll();

        CategoryResponse? GetById(int? categoryId);
    }
}
