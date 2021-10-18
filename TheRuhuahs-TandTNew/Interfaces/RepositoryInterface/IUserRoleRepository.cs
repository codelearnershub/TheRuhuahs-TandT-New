namespace TheRuhuahs_TandTNew.Interfaces.RepositoryInterface
{
    public interface IUserRoleRepository
    {
        public UserRole AddUserRole(UserRole userRole);

        public UserRole UpdateUserRole(UserRole userRole);

        public List<UserRole> GetUserRole();
    }
}