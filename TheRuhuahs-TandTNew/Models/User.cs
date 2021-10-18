namespace TheRuhuahs_TandTNew.Models
{
    public class User : BaseEntity
    {
        public List<UserRole> UserRoles { get; set;} = new List<UserRole>();
        
        public string FirstName { get; set;}

        public string LastName { get; set;}

        public string Gender { get; set;}

        public string Password { get; set;}

        public string PasswordHash { get; set;}

        public string ConfirmPassword { get; set;}

        public string HashSalt { get; set;}

        public string Email { get; set;}

        public string Mobile { get; set;}

        public DateTime DateOfBirth { get; set;}

        public string StreetAddress { get; set;}

        public string State { get; set;}

        public string Country { get; set;}

        public int RoleId { get; set;}
    }
}