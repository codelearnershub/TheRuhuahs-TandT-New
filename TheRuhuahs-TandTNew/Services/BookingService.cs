namespace TheRuhuahs_TandTNew.Services
{
    public class BookingService : IBookingService
    
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        private string GenerateReference()
        {

            Random random = new Random();

            string numberInReg = random.Next(0, 1000000).ToString("000000");

            return $"{GenerateRandomCharacter()}{GenerateRandomCharacter()}{numberInReg}{GenerateRandomCharacter()}";
            
        }

        private static char GenerateRandomCharacter()
        {
            Random random = new Random();
            int randomCharNum = random.Next(65, 91);
            char letter = (char)randomCharNum;
            return letter;
        }

        private bool ReferenceExist(List<BookingViewModel> allBookings, string reference)
        {
            foreach(var b in allBookings)
            {
                if (b.Reference.Equals(reference))
                {
                    return true;
                }
            }
            return false; 
        }
        
            public Booking AddBooking(CreateBookingViewModel model)
        {
        
            List<BookingViewModel> allBookings = GetBooking();
            string reference = "";
            do
            {
                reference = GenerateReference();
            } 
            while (ReferenceExist(allBookings, reference));
            var booking = new Booking
            {
                UserId =  model.UserId,
                NumberOfTourist = model.NumberOfTourist,
                Reference = reference,
                IsPaid = model.IsPaid,
                CreatedAt = DateTime.Now,
                Package = model.Package,
                AmountPaid = model.AmountPaid

            };
            
            return _bookingRepository.AddBooking(booking);
        }
        public Booking FindByBookingId(int id)
        {
            return _bookingRepository.FindByBookingId(id);
        }

        public void DeleteBooking(int id)
        {
            _bookingRepository.DeleteBooking(id);
        }

        public Booking UpdateBooking(UpdateBookingViewModel model)
        {   List<BookingViewModel> allBookings = GetBooking();
            string reference = "";
            do
            {
                reference = GenerateReference();
            } 
            while (ReferenceExist(allBookings, reference));
                
             var booking = new Booking
            {
                Id = model.Id,
                NumberOfTourist = model.NumberOfTourist,
                Reference = reference,
                IsPaid = model.IsPaid,
                CreatedAt = DateTime.Now,
                Package = model.Package,
                AmountPaid = model.AmountPaid

            };
            return _bookingRepository.UpdateBooking(booking);


        }
        public List<BookingViewModel> GetBooking()
        {
            var booking = _bookingRepository.GetBooking().Select(c => new BookingViewModel
            {
                Id=c.Id,
                NumberOfTourist = c.NumberOfTourist,
                CreatedAt = c.CreatedAt,
                Reference = c.Reference,
                IsPaid = c.IsPaid,
                Package = c.Package,
                TakeOffLocationId = c.TakeOffLocationId,
                AmountPaid = c.AmountPaid
               
            }).ToList();

            return booking;
        
        }

}