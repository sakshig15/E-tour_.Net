using ETour.DbRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace ETour.Repository
{
    public interface IPackageRepository
    {
        public Task<ActionResult<IEnumerable<Package>?>> getPackages();
        public Task<Package> getPackageById(int id);
    }
}