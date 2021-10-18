namespace TheRuhuahs_TandTNew.Repositories
{
    public class UserRoleRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public UserRoleRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public UserRole AddUserRole(UserRole userrole)
        {
            _dbContext.UserRoles.Add(userrole);
            _dbContext.SaveChanges();
            return userrole;
        }

        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
        }

        public UserRole UpdateUserRole(UserRole userrole)
        {
            _dbContext.UserRoles.Update(userrole);
            _dbContext.SaveChanges();
            return userrole;
        }
    }
}