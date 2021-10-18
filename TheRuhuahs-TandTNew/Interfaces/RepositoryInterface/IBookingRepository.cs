namespace TheRuhuahs_TandTNew.Interfaces.Repositories
{
    public interface IBookingRepository
    {
        public Booking AddBooking(Booking booking);

        public Booking FindByBookingId(int id);

        public Booking UpdateBooking(Booking booking);

        public void DeleteBooking(int id);

        public List<Booking> GetBooking();
    }
}