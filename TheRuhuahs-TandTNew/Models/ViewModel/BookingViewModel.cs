using System;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class BookingViewModel
    {
<<<<<<< HEAD
        public int Id { get; set;} 
=======
        public int Id { get; set;}
>>>>>>> origin/main

        public int UserId { get; set;}

        public int NumberOfTouristToBoard { get; set;}

        public string Reference { get; set;}

<<<<<<< HEAD
        public string Package { get; set;}
=======
         public string Package { get; set;}
>>>>>>> origin/main

        public decimal Amount { get; set;}

        public DateTime CreatedAt { get; set;
        }
    }
    public class CreateBookingViewModel
        {
            public int Id { get; set;}

<<<<<<< HEAD
            public int UserId { get; set;}

            public int NumberOfTouristToBoard { get; set;}
=======
        public int UserId { get; set;}

        public int NumberOfTouristToBoard { get; set;}
>>>>>>> origin/main

            public string Reference { get; set;}

<<<<<<< HEAD
            public string Package { get; set;}
=======
        public string Package { get; set;}
>>>>>>> origin/main

            public decimal Amount { get; set;}

            public DateTime CreatedAt { get; set;
        }
        public class UpdateBookingViewModel : CreateBookingViewModel
        {
            
        }
    }
<<<<<<< HEAD
=======
    public class UpdateBookingViewModel : CreateBookingViewModel
    {
        
    }

    }

>>>>>>> origin/main
}