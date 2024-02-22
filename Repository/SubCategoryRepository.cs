using ETour.DbRepos;
using ETour.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ETour.Repository
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly ScottDbContext context;

        public SubCategoryRepository(ScottDbContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<IEnumerable<SubCategory>?>> getSubcategories()
        {
            if(context.SubCategories == null)
            {
                return null;
            }
            return context.SubCategories.ToList();
        }

        public async Task<SubCategory> getSubCategoryById(int id)
        {
            if(context.SubCategories==null)
            {
                return null;
            }
            var subcategory = await context.SubCategories.FindAsync();
            if(subcategory==null)
            {
                return null;
            }
            return subcategory;
        }
    }
}
