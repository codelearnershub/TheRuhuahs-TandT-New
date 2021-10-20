using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.DbContext;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Repositories
{
    public class TouristCenterRepository : ITouristCenterRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public TouristCenterRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public TouristCenter AddTouristCenter(TouristCenter touristCenter)
        {
            _dbContext.TouristCenters.Add(touristCenter);
            _dbContext.SaveChanges();
            return touristCenter;
        }
        public TouristCenter FindByTouristCenterId(int id)
        {
            return _dbContext.TouristCenters.Find(id);
        }
        public TouristCenter UpdateTouristCenter(TouristCenter touristCenter)
        {
            _dbContext.TouristCenters.Update(touristCenter);
            _dbContext.SaveChanges();
            return touristCenter;
        }
        public void DeleteTouristCenter(int id)
        {
            var touristCenter = FindByTouristCenterId(id);

            if (touristCenter != null)
            {
                _dbContext.TouristCenters.Remove(touristCenter);
                _dbContext.SaveChanges();
            }
        }
        public List<TouristCenter> GetTouristCenter()
        {
            return _dbContext.TouristCenters.ToList();
        }
    }
}