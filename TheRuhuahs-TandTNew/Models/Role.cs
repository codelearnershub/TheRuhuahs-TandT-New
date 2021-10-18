namespace TheRuhuahs_TandTNew.Models
{
    public class Role : BaseEntity
    {
        public List<UserRole> UserRoles { get; set;}

        public string RoleName { get; set;}
    }
}