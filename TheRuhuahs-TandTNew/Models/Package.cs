namespace TheRuhuahs_TandTNew.Models
{
    public class Package : BaseEntity
    {
        public int TripId { get; set;}

        public string HotelStandard { get; set;}

        public decimal HotelExpense { get; set;}

        public string FeedingStandard { get; set;}

        public decimal FeedingExpense { get; set;}  

        public string TransportationStandard { get; set;}

        public decimal TransportationExpense { get; set;}
    }
}