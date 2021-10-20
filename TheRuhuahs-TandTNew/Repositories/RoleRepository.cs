using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.Context;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public RoleRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public Role AddRole(Role role)
        {
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
            return role;
        }
        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
        }
        public Role FindByRoleName(string name)
        {
            return _dbContext.Roles.Where(r => r.RoleName == name.ToLower()).SingleOrDefault();
        }
        public Role UpdateRole(Role role)
        {
            _dbContext.Roles.Update(role);
            _dbContext.SaveChanges();
            return role;
        }
        public void DeleteRole(string name)
        {
            var role = FindByRoleName(name);

            if (role != null)
            {
                _dbContext.Roles.Remove(role);
                _dbContext.SaveChanges();
            }
        }
        public List<Role> GetRole()
        {
            return _dbContext.Roles.ToList();
        }
    }
}