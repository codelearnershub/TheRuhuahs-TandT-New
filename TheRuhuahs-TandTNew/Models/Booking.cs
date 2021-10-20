namespace TheRuhuahs_TandTNew.Models
{
    public class Booking : BaseEntity
    {
        public int UserId { get; set;}

        public User User {get; set;}

        public int NumberOfTouristToBoard { get; set;}

        public string Reference { get; set;}

        public string Package { get; set;}

        public decimal Amount { get; set;}
    }
}