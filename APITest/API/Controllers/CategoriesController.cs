using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;

namespace API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult Index()
        {
            List<CategoryResponse> categories = _categoriesService.GetAll();

            return new OkObjectResult(categories);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int? id)
        {
            CategoryResponse category = _categoriesService.GetById(id);

            if (category == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(category);
        }
    }
}
