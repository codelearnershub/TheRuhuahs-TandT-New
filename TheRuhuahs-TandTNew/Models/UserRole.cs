namespace TheRuhuahs_TandTNew.Models
{
    public class UserRole : BaseEntity
    {
       public int UserId { get; set;}

        public User User { get; set;}
        
        public int RoleId { get; set;}

        public Role Role { get; set;} 
    }
}