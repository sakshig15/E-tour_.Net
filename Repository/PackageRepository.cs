﻿using ETour.DbRepos;
using ETour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace Etour_DotNet_Backend.Repository
{
    public class PackageRepository : IPackageRepository
    {

        private readonly ScottDbContext _context;

        public PackageRepository(ScottDbContext context)
        {
            _context = context;
        }


        public async Task<Package> getPackageById(int id)
        {
            if (_context.Packages == null)
            {
                return null;
            }
            var package = await _context.Packages.FindAsync(id);
            if (package == null)
            {
                return null;
            }
            return package;
        }

        public async Task<ActionResult<IEnumerable<Package>?>> getPackages()
        {
            if (_context.Packages == null) { return null; }
            return _context.Packages.ToList();
        }
    }
}