using System.Collections.Generic;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
        public interface IRoleService
    {
        public Role AddRole(CreateRoleViewModel model);

        public Role UpdateRole(UpdateRoleViewModel model);
      
        public Role FindByRoleName(string name);
       
        public void DeleteRole(string name);

        public List<RoleViewModel> GetRole();
    }
    
}