using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class TouristCenterViewModel
    {
        public int Id { get; set;}
        public string Name { get; set;}

        public string Description { get; set;}

        public string Location { get; set;}

        
        public string Image { get; set; } 
    }
    public class CreateTouristCenterViewModel
    {
        public int Id { get; set;}
        public string Name { get; set;}

        public string Description { get; set;}

        public string Location { get; set;}

        [DisplayName("Item Picture URL")]
        [StringLength(1024)]
        public string Image { get; set; } 
    }
    public class UpdateTouristCenterViewModel : CreateTouristCenterViewModel
    {

    }
    // public class List<TouristCenterViewModel> 
    // {
    //     public int Id { get; set;}
    //     public string Name { get; set;}

    //     public string Description { get; set;}

    //     public string Location { get; set;}

    //     public string Image { get; set; }
    // }
}