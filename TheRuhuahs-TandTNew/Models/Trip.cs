using System;

namespace TheRuhuahs_TandTNew.Models
{
    public class Trip : BaseEntity
    {
        public int TouristCenterId { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}

        public int NumberOfTouristRequired { get; set;}
    }
}