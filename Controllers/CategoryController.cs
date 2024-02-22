using ETour.Repository;
using Microsoft.AspNetCore.Mvc;
using ETour.DbRepos;
using NuGet.Protocol.Core.Types;

namespace ETour.Controllers
{
    [ApiController]
    [Route("/api/category")]   
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>?>> GetCategory()
        {
            if(await categoryRepository.getCategories() == null)
            {
                return NotFound();
            }
            return await categoryRepository.getCategories();
        }

        [HttpGet("{$id}")]
        public async Task<Category> getCategoryById(int id)
        {
            var Category = await categoryRepository.getCategoryById(id);
            return Category;
        }
    }

}
