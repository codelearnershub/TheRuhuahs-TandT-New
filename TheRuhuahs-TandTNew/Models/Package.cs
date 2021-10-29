namespace TheRuhuahs_TandTNew.Models
{
    public class Package : BaseEntity
    {
        public int TripId { get; set;}

        public Trip Trip { get; set;}

        public string PackageType { get; set;}

        public string HotelStandard { get; set;}

        public decimal HotelExpense { get; set;}

        public decimal FeedingExpense { get; set;}  

    }
}