namespace TheRuhuahs_TandTNew.Interfaces.Repositories
{
    public interface ITouristCenterRepository
    {
        public TouristCenter AddTouristCenter(TouristCenter touristCenter);

        public TouristCenter FindByTouristCenterId(int id);

        public TouristCenter UpdateTouristCenter(TouristCenter touristCenter);

        public void DeleteTouristCenter(int id);

        public List<TouristCenter> GetTouristCenter();
    }
}