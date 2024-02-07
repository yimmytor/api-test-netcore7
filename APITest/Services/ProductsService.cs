using Entities;
using Business;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class ProductsService : IProductsService
    {
        private ProductResponse ConvertToResponse(Product product)
        {
            ProductResponse productResponse = product.ToProductResponse();

            return productResponse;
        }

        public List<ProductResponse> GetAll()
        {
            return ProductB.GetAll().Select(product => ConvertToResponse(product)).ToList();
        }

        public ProductResponse? GetById(int? productId)
        {
            if (productId == 0 || productId == null)
            {
                return null;
            }

            return ProductB.GetById(productId).ToProductResponse();
        }

        public List<ProductResponse> SearchByText(string? searchText)
        {
            if (String.IsNullOrEmpty(searchText))
            {
                return new List<ProductResponse>() { };
            }

            return ProductB.SearchByText(searchText).Select(product => ConvertToResponse(product)).ToList();
        }

        public List<ProductResponse> SearchByCategory(int? categoryId)
        {
            if (categoryId == 0 || categoryId == null)
            {
                return new List<ProductResponse>(){ };
            }

            return ProductB.SearchByCategory(categoryId).Select(product => ConvertToResponse(product)).ToList();
        }
    }
}
