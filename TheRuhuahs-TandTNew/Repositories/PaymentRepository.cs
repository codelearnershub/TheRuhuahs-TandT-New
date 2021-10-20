using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.Context;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public PaymentRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public Payment AddPayment(Payment payment)
        {
            _dbContext.Payments.Add(payment);
            _dbContext.SaveChanges();
            return payment;
        }
        public Payment FindByPaymentId(int id)
        {
            return _dbContext.Payments.Find(id);
        }
        public Payment UpdatePayment(Payment payment)
        {
            _dbContext.Payments.Update(payment);
            _dbContext.SaveChanges();
            return payment;
        }
        public void DeletePayment(int id)
        {
            var payment = FindByPaymentId(id);

            if (payment != null)
            {
                _dbContext.Payments.Remove(payment);
                _dbContext.SaveChanges();
            }
        }
        public List<Payment> GetPayment()
        {
            return _dbContext.Payments.ToList();
        }
    }
}