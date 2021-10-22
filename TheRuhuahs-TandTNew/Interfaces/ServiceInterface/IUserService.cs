using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
    public interface IUserService
    {
        public void RegisterUser(RegisterViewModel model);

        public User LoginUser(string email, string password);
    }
}