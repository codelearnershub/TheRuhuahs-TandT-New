namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
    public class IRoleService
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
}