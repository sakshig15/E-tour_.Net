using ETour.DbRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace ETour.Repository
{
    public interface ISubCategoryRepository
    {
        public Task<ActionResult<IEnumerable<SubCategory>?>> getSubcategories();
        public Task<SubCategory> getSubCategoryById(int id);
    }
}
