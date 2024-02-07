using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult Index()
        {
            List<ProductResponse> products = _productsService.GetAll();

            return new OkObjectResult(products);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int? id)
        {
            ProductResponse product = _productsService.GetById(id);

            if (product == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(product);
        }

        [HttpGet]
        [Route("[action]/{text}")]
        public IActionResult Search(string? text)
        {
            List<ProductResponse> products = _productsService.SearchByText(text);

            if (products == null)
            {
                return new OkObjectResult(new List<ProductResponse>());
            }

            return new OkObjectResult(products);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult Category(int? id)
        {
            List<ProductResponse> products = _productsService.SearchByCategory(id);

            if (products == null)
            {
                return new OkObjectResult(new List<ProductResponse>());
            }

            return new OkObjectResult(products);
        }
    }
}
