using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.DbContext;
using TheRuhuahs_TandTNew.Interfaces.RepositoryInterface;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
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

        public List<UserRole> GetUserRole()
        {
            return _dbContext.UserRoles.ToList();
        }

        public UserRole UpdateUserRole(UserRole userrole)
        {
            _dbContext.UserRoles.Update(userrole);
            _dbContext.SaveChanges();
            return userrole;
        }
    }
}