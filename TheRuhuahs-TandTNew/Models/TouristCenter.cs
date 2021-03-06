using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheRuhuahs_TandTNew.Models
{
    public class TouristCenter : BaseEntity
    {
        public string Name { get; set;}

        public string Description { get; set;}

        public string Location { get; set;}

        [DisplayName("Item Picture URL")]
        [StringLength(1024)]
        public string Image { get; set; } 

        public List<Trip> Trip { get; set;}
    }
}