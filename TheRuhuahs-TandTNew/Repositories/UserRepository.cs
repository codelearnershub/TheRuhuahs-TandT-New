namespace TheRuhuahs_TandTNew.Repositories
{
    public class UserRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public User AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
        }
        public User FindByUserEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email.Equals(email));
        }
        public User FindByUserId(int id)
        {
            return _dbContext.Users.Find(id);
        }
        public User UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }
        public void DeleteUser(int id)
        {
            var user = FindByUserId(id);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
        public List<User> GetUser()
        {
            return _dbContext.Users.ToList();
        }
    }
}