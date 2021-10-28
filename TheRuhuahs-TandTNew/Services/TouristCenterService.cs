using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Services
{
    public class TouristCenterService : ITouristCenterService
    {
        private readonly ITouristCenterRepository _touristCenterRepository;

        public TouristCenterService(ITouristCenterRepository touristCenterRepository)
        {
            _touristCenterRepository = touristCenterRepository;
        }

        public TouristCenter AddTouristCenter(CreateTouristCenterViewModel model)
        {
          
            var touristCenter = new TouristCenter
            {
                Name = model.Name,
                Description = model.Description,
                Location = model.Location,
                Image = model.Image

            };
          
            return _touristCenterRepository.AddTouristCenter(touristCenter);
        }
        public TouristCenter UpdateTouristCenter(UpdateTouristCenterViewModel model)
        {
            var touristCenter = _touristCenterRepository.FindByTouristCenterId(model.Id);
            if (touristCenter == null)
            {
                return null;
            }

            touristCenter.Id = model.Id;
            touristCenter.Name = model.Name;
            touristCenter.Description = model.Description;
            touristCenter.Location = model.Location;

            return _touristCenterRepository.UpdateTouristCenter(touristCenter);
        }

        public TouristCenter FindByTouristCenterId(int id)
        {
            return _touristCenterRepository.FindByTouristCenterId(id);
        }

        public void DeleteTouristCenter(int id)
        {
            _touristCenterRepository.DeleteTouristCenter(id);
        }
        public List<TouristCenterViewModel> GetTouristCenter()
        {
            var touristCenter = _touristCenterRepository.GetTouristCenter().Select(c => new TouristCenterViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Location = c.Location,
                // Image = $"{WC.ImagePath}{c.Image}"
                Image = c.Image
               
            }).ToList();

            return touristCenter;
        
        }
    }
}