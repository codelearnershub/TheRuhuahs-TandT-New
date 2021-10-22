using System.Collections.Generic;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Interfaces.ServiceInterface
{
    public interface IPaymentService
    {
        public Payment AddPayment(CreatePaymentViewModel model);

        public Payment UpdatePayment(UpdatePaymentViewModel model);
      
        public Payment FindByPaymentId(int id);
       
        public void DeletePayment(int id);

        public List<PaymentViewModel> GetPayment();
    }

}