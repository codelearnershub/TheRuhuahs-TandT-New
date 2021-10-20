namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class PackageViewModel
    {
        public int Id { get; set;}

        public int CreatedAt { get; set;}

        public int TripId { get; set;}

        public string HotelStandard { get; set;}

        public decimal HotelExpense { get; set;}

        public string FeedingStandard { get; set;}

        public decimal FeedingExpense { get; set;}  

        public string TransportationStandard { get; set;}

    }
    public class CreatePackageViewModel
    {
        public int Id { get; set;}

        public int CreatedAt { get; set;}

        public int TripId { get; set;}

        public string HotelStandard { get; set;}

        public decimal HotelExpense { get; set;}

        public string FeedingStandard { get; set;}

        public decimal FeedingExpense { get; set;}  

        public string TransportationStandard { get; set;}
    }
}