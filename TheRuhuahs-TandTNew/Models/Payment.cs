namespace TheRuhuahs_TandTNew.Models
{
    public class Payment : BaseEntity
    {
        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public int BookingId { get; set;}
    }
}