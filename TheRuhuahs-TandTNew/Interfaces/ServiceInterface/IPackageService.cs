namespace TheRuhuahs_TandTNew.Interfaces.Service
{
    public interface IPackageService
    {
        public Package AddPackage(CreatePackageViewModel model);

        public Package UpdatePackage(UpdatePackageViewModel model);
      
        public Package FindByPackageId(int id);
       
        public void DeletePackage(int id);

        public List<PackageViewModel> GetPackage();
    }