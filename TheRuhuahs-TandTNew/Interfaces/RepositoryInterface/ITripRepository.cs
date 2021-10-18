namespace TheRuhuahs_TandTNew.Interfaces.Repositories
{
    public interface ITripRepository
    {
        public Trip AddTrip(Trip trip);

        public Trip FindByTripId(int id);

        public Trip UpdateTrip(Trip trip);

        public void DeleteTrip(int id);

        public List<Trip> GetTrip();
    }
}