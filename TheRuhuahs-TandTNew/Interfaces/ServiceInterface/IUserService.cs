using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
    public interface IUserService
    {
        public void Register(RegisterViewModel model);

        public void RegisterCustomer(RegisterCustomerViewModel model);

        public User LoginUser(string email, string password);
        public User FindByUserId(int id);
    }
}