namespace TheRuhuahs_TandTNew.Interfaces.Repositories
{
    public interface IPackageRepository
    {
        public Package AddPackage(Package package);

        public Package FindByPackageId(int id);

        public Package UpdatePackage(Package package);

        public void DeletePackage(int id);

        public List<Package> GetPackage();
    }
}