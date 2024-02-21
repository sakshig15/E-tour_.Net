using ETour.DbRepos;
using Microsoft.CodeAnalysis;

namespace ETour.Repository
{
    public interface ICategoryRepository
    {
        public List<Category> getCategory();
        public Optional<Category> getCategoryById(int id);


    }
}
