using ETour.DbRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace ETour.Repository
{
    public interface ICategoryRepository
    {

        public Task<ActionResult<IEnumerable<Category>?>> getCategories();
        public Task<Category> getCategoryById(int id);
    }
}
