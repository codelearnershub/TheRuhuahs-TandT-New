using System.Collections.Generic;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
    public interface ITripService
    {
        public Trip AddTrip(CreateTripViewModel model);

        public Trip UpdateTrip(UpdateTripViewModel model);
      
        public Trip FindByTripId(int id);
       
        public void DeleteTrip(int id);

        public List<TripViewModel> GetTrip();
    }
}