namespace TheRuhuahs_TandTNew.Interfaces.Repositories
{
    public interface IUserRepository

    {
        public User AddUser(User user);
        
        public List<UserRole> FindUserRoles(int userId);

        public User FindByUserId(int id);

        public User FindByUserEmail(string email);

        public User UpdateUser(User user);

        public void DeleteUser(int id);

        public List<User> GetUser();

        
       
    }
}