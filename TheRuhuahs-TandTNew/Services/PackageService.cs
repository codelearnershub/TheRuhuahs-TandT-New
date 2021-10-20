using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Interfaces.Service;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Services
{
     public class PackageService : IPackageService
    {
        private readonly IPackageRepository _packageRepository;

        public PackageService(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public Package AddPackage(CreatePackageViewModel model)
        {
            var package = new Package
            {
                
                TripId = model.TripId,
                HotelStandard = model.HotelStandard,
                HotelExpense = model.HotelExpense,
                FeedingExpense = model.FeedingExpense

            };
            
            return _packageRepository.AddPackage(package);
        }
        public Package UpdatePackage(UpdatePackageViewModel model)
        {
            var package = new Package
            {
                TripId = model.TripId,
                HotelStandard = model.HotelStandard,
                HotelExpense = model.HotelExpense,
                FeedingExpense = model.FeedingExpense

            };
            return _packageRepository.UpdatePackage(package);
        }

        public Package FindByPackageId(int id)
        {
            return _packageRepository.FindByPackageId(id);
        }

        public void DeletePackage(int id)
        {
            _packageRepository.DeletePackage(id);
        }
        public List<PackageViewModel> GetPackage()
        {
            var package = _packageRepository.GetPackage().Select(c => new PackageViewModel
            {
                Id = c.Id,
                TripId = c.TripId,
                HotelStandard = c.HotelStandard,
                HotelExpense = c.HotelExpense,
                FeedingExpense = c.FeedingExpense
               
            }).ToList();

            return package;
        
        }
    }
}