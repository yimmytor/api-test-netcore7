using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface IProductsService
    {
        List<ProductResponse> GetAll();

        List<ProductResponse> SearchByText(string? searchText);

        List<ProductResponse> SearchByCategory(int? categoryId);

        ProductResponse? GetById(int? productId);
    }
}
