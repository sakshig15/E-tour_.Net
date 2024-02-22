using ETour.DbRepos;
using ETour.Repository;
using Etour_DotNet_Backend.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace ETour.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryRepository repository;

        public SubCategoryController(ISubCategoryRepository repository)
        {
            this.repository = repository;
        }


        public async Task<ActionResult<IEnumerable<SubCategory>?>> getCategories()
        {
            if (await repository.getSubcategories() == null)
            {
                return null;
            }

            return await repository.getSubcategories();
        }

        [HttpGet("{id}")]
        public async Task<SubCategory> getCategoryById(int id)
        {
            var subcategory = await repository.getSubCategoryById(id);
            return subcategory;
        }



    }
}