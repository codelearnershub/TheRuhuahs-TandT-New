namespace TheRuhuahs_TandTNew.Interfaces.Repositories
{
    public interface IPaymentRepository
    {
        public Payment AddPayment(Payment payment);

        public Payment FindByPaymentId(int id);

        public Payment UpdatePayment(Payment payment);

        public void DeletePayment(int id);

        public List<Payment> GetPayment();
    }
}