using System.Collections.Generic;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
    public interface ITouristCenterService
    
    {  
        public TouristCenter AddTouristCenter(CreateTouristCenterViewModel touristCenter);

        public TouristCenter UpdateTouristCenter(UpdateTouristCenterViewModel model);

      
        public TouristCenter FindByTouristCenterId(int id);
       
        public void DeleteTouristCenter(int id);

        public List<TouristCenterViewModel> GetTouristCenter();
    }
}