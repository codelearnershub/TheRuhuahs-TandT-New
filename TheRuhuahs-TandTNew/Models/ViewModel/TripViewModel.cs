using System;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class TripViewModel
    {
        public int Id { get; set;}

        public DateTime CreatedAt { get; set;}

        public int TouristCenterId { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}

        public int NumberOfTouristRequired { get; set;}
    }
    public class CreateTripViewModel
    {
        public int Id { get; set;}
        public DateTime CreatedAt { get; set;}

        public DateTime Created{ get; set;}
        public int TouristCenterId { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}

        public int NumberOfTouristRequired { get; set;}
    }
    public class UpdateTripViewModel
    {
        public int Id { get; set;}

        public DateTime CreatedAt { get; set;}
        public int TouristCenterId { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}

        public int NumberOfTouristRequired { get; set;}
    }
}