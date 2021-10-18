
namespace TheRuhuahs_TandTNew.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public BookingRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public Booking AddBooking(Booking booking)
        {
            _dbContext.Bookings.Add(booking);
            _dbContext.SaveChanges();
            return booking;
        }
        public Booking FindByBookingId(int id)
        {
            return _dbContext.Bookings.Find(id);
        }
        public Booking UpdateBooking(Booking booking)
        {
            _dbContext.Bookings.Update(booking);
            _dbContext.SaveChanges();
            return booking;
        }
        public void DeleteBooking(int id)
        {
            var booking = FindByBookingId(id);

            if (booking != null)
            {
                _dbContext.Bookings.Remove(booking);
                _dbContext.SaveChanges();
            }
        }
        public List<Booking> GetBooking()
        {
            return _dbContext.Bookings.ToList();
        }
    }
}