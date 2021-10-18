namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
    public interface IUserService
    {
        public void RegisterUser(RegisterViewModel model);

        public User LoginUser(string email, string password);
    }
}