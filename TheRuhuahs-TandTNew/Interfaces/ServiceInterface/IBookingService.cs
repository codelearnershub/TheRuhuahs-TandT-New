using System.Collections.Generic;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;
using static TheRuhuahs_TandTNew.Models.ViewModel.CreateBookingViewModel;

namespace TheRuhuahs_TandTNew.Interfaces.Service
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