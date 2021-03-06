using System;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class BookingViewModel
    {
        public int Id { get; set;}

        public int UserId { get; set;}

        public int NumberOfTouristToBoard { get; set;}

        public string Reference { get; set;}

         public int PackageId { get; set;}

        public decimal Amount { get; set;}

        public DateTime CreatedAt { get; set;
        }
    }
    public class CreateBookingViewModel
        {
            public int Id { get; set;}

            public int UserId { get; set;}

            public int NumberOfTouristToBoard { get; set;}

            public string Reference { get; set;}

            public int PackageId { get; set;}

            public decimal Amount { get; set;}

            public DateTime CreatedAt { get; set;
        }
        public class UpdateBookingViewModel : CreateBookingViewModel
        {
            
        }
    }
}