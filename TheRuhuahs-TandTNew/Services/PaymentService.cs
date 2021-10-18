namespace TheRuhuahs_TandTNew.Services
{
    public class PackageService : IPackageService
    {
        public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Payment AddPayment(CreatePaymentViewModel model)
        {
            var payment = new Payment
            {
                Id = model.UserId,
                UserId = model.UserId,
                Amount = model.Amount,
                CreatedAt = model.CreatedAt,
                BookingId = model.BookingId

            };
            
            return _paymentRepository.AddPayment(payment);
        }
        public Payment UpdatePayment(UpdatePaymentViewModel model)
        {
            var payment = new Payment
            {
                UserId = model.UserId,
                Amount = model.Amount,
                CreatedAt = model.CreatedAt,
                BookingId = model.BookingId

            };
            return _paymentRepository.UpdatePayment(payment);
        }

        public Payment FindByPaymentId(int id)
        {
            return _paymentRepository.FindByPaymentId(id);
        }

        public void DeletePayment(int id)
        {
            _paymentRepository.DeletePayment(id);
        }
        public List<PaymentViewModel> GetPayment()
        {
            var payment = _paymentRepository.GetPayment().Select(c => new PaymentViewModel
            {
                UserId = c.UserId,
                Amount = c.Amount,
                CreatedAt = c.CreatedAt,
                BookingId = c.BookingId
               
            }).ToList();

            return payment;
        }
        
    
    }
}