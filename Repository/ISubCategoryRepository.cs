using ETour.DbRepos;
using Microsoft.CodeAnalysis;

namespace ETour.Repository
{
    public interface ISubCategory
    {
        public List<SubCategory> getSubCategory();
        public Optional<SubCategory> getSubCategoryById(int id);

    }
}
