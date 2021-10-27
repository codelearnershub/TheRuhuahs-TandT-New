using System;
using System.Collections.Generic;

namespace TheRuhuahs_TandTNew.Models
{
    public class Trip : BaseEntity
    {
        public int TouristCenterId { get; set;}

        public string Name { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}

        public int NumberOfTouristRequired { get; set;}

        public List<Package> Package { get; set;}
    }
}