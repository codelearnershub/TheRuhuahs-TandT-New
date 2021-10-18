namespace TheRuhuahs_TandTNew.Services
{
    public class TripService : ITripService
    {
        private readonly ITripRepository _tripRepository;

        public TripService(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }
     


        public Trip AddTrip(CreateTripViewModel model)
        {
            var trip = new Trip
            {
                TouristCenterId = model.TouristCenterId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                NumberOfTourist = model.NumberOfTourist

            };
            if(model.TouristCenterId == trip.TouristCenterId)
            {
               
            }
            
            return _tripRepository.AddTrip(trip);
        }
        public Trip UpdateTrip(UpdateTripViewModel model)
        {
            var trip = new Trip
            {
                Id = model.Id,
                TouristCenterId = model.TouristCenterId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                NumberOfTourist = model.NumberOfTourist,
                
            };
            return _tripRepository.UpdateTrip(trip);
        }

        public Trip FindByTripId(int id)
        {
            return _tripRepository.FindByTripId(id);
        }

        public void DeleteTrip(int id)
        {
            _tripRepository.DeleteTrip(id);
        }
        public List<TripViewModel> GetTrip()
        {
            var trip = _tripRepository.GetTrip().Select(c => new TripViewModel
            {
                Id = c.Id,
                TouristCenterId = c.TouristCenterId,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                NumberOfTourist = c.NumberOfTourist,
                
               
            }).ToList();

            return trip;
        }

}