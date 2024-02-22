using ETour.DbRepos;
using ETour.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ETour.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ScottDbContext context;

        public CategoryRepository(ScottDbContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<IEnumerable<Category>?>> getCategories()
        {
            if(context == null)
            {
                return null;
            }
            return context.Categories.ToList();

        }

        public async Task<Category> getCategoryById(int id)
        {
            if(context == null)
            {
                return null;
            }
            var category = await context.Categories.FindAsync(id);
            if(category == null)
            {
                return null;
            }
            return category;
        }
    }
}
