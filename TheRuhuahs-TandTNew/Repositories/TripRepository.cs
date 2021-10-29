using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TheRuhuahs_TandTNew.Context;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Repositories
{
    public class TripRepository : ITripRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public TripRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public Trip AddTrip(Trip trip)
        {
            _dbContext.Trips.Add(trip);
            _dbContext.SaveChanges();
            return trip;
        }
        public Trip FindByTripId(int id)
        {
            return _dbContext.Trips.Find(id);
        }
        public Trip UpdateTrip(Trip trip)
        {
            _dbContext.Trips.Update(trip);
            _dbContext.SaveChanges();
            return trip;
        }
        public void DeleteTrip(int id)
        {
            var trip = FindByTripId(id);

            if (trip != null)
            {
                _dbContext.Trips.Remove(trip);
                _dbContext.SaveChanges();
            }
        }
        public List<Trip> GetTrip()
        {
            return _dbContext.Trips.ToList();
        }
        
        public IEnumerable<Trip> GetAllTripInEachTouristCenter(int touristCenterId)
        {
            return _dbContext.Trips.Include(u => u.TouristCenter).Where(c => c.TouristCenterId == touristCenterId).ToList();
        }
        
    }
}