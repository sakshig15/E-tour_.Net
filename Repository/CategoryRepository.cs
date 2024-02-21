using ETour.DbRepos;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ETour.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> getCategory()
        {
            throw new NotImplementedException();
        }

        public Optional<Category> getCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
