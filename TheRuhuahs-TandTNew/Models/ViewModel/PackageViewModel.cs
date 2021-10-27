using System;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class PackageViewModel
    {
        public int Id { get; set;}
        public int TripId { get; set;}

        public string PackageType { get; set;}
        public DateTime CreatedAt { get; set;}

        public string HotelStandard { get; set;}

        public decimal HotelExpense { get; set;}

        public decimal FeedingExpense { get; set;}

    }
    public class CreatePackageViewModel
    {
        public int Id { get; set;}

        public int TripId { get; set;}

        public string PackageType { get; set;}

        public DateTime CreatedAt { get; set;}

        public string HotelStandard { get; set;}

        public decimal HotelExpense { get; set;}

        public decimal FeedingExpense { get; set;} 
    }
    public class UpdatePackageViewModel : CreatePackageViewModel
    {

    }
}