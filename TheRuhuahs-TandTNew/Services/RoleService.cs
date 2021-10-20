using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public Role AddRole(CreateRoleViewModel model)
        {
            var role = new Role
            {
                Id = model.Id,
                RoleName = model.RoleName

            };
            
            return _roleRepository.AddRole(role);
        }
        public Role UpdateRole(UpdateRoleViewModel model)
        {
            var role = new Role
            {
                RoleName = model.RoleName

            };
            return _roleRepository.UpdateRole(role);
        }

        public Role FindByRoleName(string name)
        {
            return _roleRepository.FindByRoleName(name);
        }

        public void DeleteRole(string name)
        {
            _roleRepository.DeleteRole(name);
        }
        public List<RoleViewModel> GetRole()
        {
            var role = _roleRepository.GetRole().Select(c => new RoleViewModel
            {
                RoleName = c.RoleName,
                
               
            }).ToList();

            return role;
        }
    }
}