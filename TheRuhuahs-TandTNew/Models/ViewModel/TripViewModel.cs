using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class TripViewModel
    {
        public int Id { get; set;}

        public string Name { get; set;}

        public DateTime CreatedAt { get; set;}

        public int TouristCenterId { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}
        public string Package { get; set;}

        public int NumberOfTouristRequired { get; set;}
    }
    public class CreateTripViewModel
    {
        public int Id { get; set;}

        public string Name { get; set;}
        public DateTime CreatedAt { get; set;}

        public DateTime Created{ get; set;}
        public int TouristCenterId { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}

        public int NumberOfTouristRequired { get; set;}
        public IEnumerable<SelectListItem> TouristCenterList { get; set; }
    }
    public class UpdateTripViewModel : CreateTripViewModel
    {
       
    }
}