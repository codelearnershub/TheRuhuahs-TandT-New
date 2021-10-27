using System;
using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

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
                Id = model.Id,
                Name = model.Name,
                CreatedAt = DateTime.Now,
                TouristCenterId = model.TouristCenterId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                NumberOfTouristRequired = model.NumberOfTouristRequired

            };
            
            
            return _tripRepository.AddTrip(trip);
        }
        public Trip UpdateTrip(UpdateTripViewModel model)
        {
            var trip = _tripRepository.FindByTripId(model.Id);
            if (trip == null)
            {
                return null;
            }

            trip.Id = model.Id;
            trip.Name = model.Name;
            trip.CreatedAt = DateTime.Now;
            trip.TouristCenterId = model.TouristCenterId;
            trip.StartDate = model.StartDate;
            trip.EndDate = model.EndDate;
            trip.NumberOfTouristRequired = model.NumberOfTouristRequired;

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
                Name = c.Name,
                CreatedAt = c.CreatedAt,
                TouristCenterId = c.TouristCenterId,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                NumberOfTouristRequired = c.NumberOfTouristRequired,
                
               
            }).ToList();

            return trip;
        }
    }

}