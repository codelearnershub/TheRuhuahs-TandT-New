namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class PaymentViewModel
    {
        public int Id {get; set;}

        public int CreatedAt { get; set;}

        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public int BookingId { get; set;}
    }
    public class CreatePaymentViewModel
    {
        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public int BookingId { get; set;}
    }
}