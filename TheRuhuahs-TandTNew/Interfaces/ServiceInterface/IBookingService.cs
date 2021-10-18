namespace TheRuhuahs_TandTNew.Interfaces.Service
{
    public class IBookingService
    {
        public interface IBookingService
    {
        public Booking AddBooking(CreateBookingViewModel model);

        public Booking UpdateBooking(UpdateBookingViewModel model);
        
        public Booking FindByBookingId(int id);
       
        public void DeleteBooking(int id);

        public List<BookingViewModel> GetBooking();
    }
    }
}