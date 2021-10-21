namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class TripViewModel
    {
        public int Id { get; set;}

        public int CreatedAt { get; set;}

        public int UserId { get; set;}

        public User User {get; set;}

        public int NumberOfTouristToBoard { get; set;}

        public string Reference { get; set;}

        public string Package { get; set;}

        public decimal Amount { get; set;}
    }
    public class CreateTripViewModel
    {
        public int UserId { get; set;}

        public User User {get; set;}

        public int NumberOfTouristToBoard { get; set;}

        public string Reference { get; set;}

        public string Package { get; set;}

        public decimal Amount { get; set;}
    }
}