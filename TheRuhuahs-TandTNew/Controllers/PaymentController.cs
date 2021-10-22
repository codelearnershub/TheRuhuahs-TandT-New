using Microsoft.AspNetCore.Mvc;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public IActionResult Index()
        {
            var payment = _paymentService.GetPayment();
            return View(payment);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPayment(CreatePaymentViewModel model)
        {
            _paymentService.AddPayment(model);

            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdatePaymentViewModel model)
        {
            _paymentService.UpdatePayment(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Find(int id)
        {
            _paymentService.FindByPaymentId(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete (int id)
        {
            _paymentService.DeletePayment(id);
            return RedirectToAction("Index");
        }
    }
}