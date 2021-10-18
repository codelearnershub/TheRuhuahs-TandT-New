namespace TheRuhuahs_TandTNew.Models
{
    public class Payment
    {
        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public int BookingId { get; set;}
    }
}