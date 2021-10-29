using System.Collections.Generic;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Interfaces.Repositories
{
    public interface IRoleRepository
    {
        public Role AddRole(Role role);

        public Role FindByRoleName(string name);

        public Role FindByRoleId(int id);

        public Role UpdateRole(Role role);

        public void DeleteRole(string name);

        public void DeleteByRoleId(int id);

        public List<Role> GetRole();
    }
}