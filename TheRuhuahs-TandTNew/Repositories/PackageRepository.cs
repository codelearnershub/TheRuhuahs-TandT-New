using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.DbContext;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Repositories
{
    public class PackageRepository : IPackageRepository
    {
      public readonly ApplicationDbContext _dbContext;
        public PackageRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public Package AddPackage(Package package)
        {
            _dbContext.Packages.Add(package);
            _dbContext.SaveChanges();
            return package;
        }
        public Package FindByPackageId(int id)
        {
            return _dbContext.Packages.Find(id);
        }
        public Package UpdatePackage(Package package)
        {
            _dbContext.Packages.Update(package);
            _dbContext.SaveChanges();
            return package;
        }
        public void DeletePackage(int id)
        {
            var package = FindByPackageId(id);

            if (package != null)
            {
                _dbContext.Packages.Remove(package);
                _dbContext.SaveChanges();
            }
        }
        public List<Package> GetPackage()
        {
            return _dbContext.Packages.ToList();
        } 
    }
}