using ProductRepo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepo1.Repository
{
   public class PaymentRepository : IRepository<Payment>
    {
        ProductDBContext db = new ProductDBContext();
        public int Create(Payment entity)
        {
            db.Payments.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }

        public void Delete(int id)
        {
            var p = db.Payments.Where(p => p.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.Payments.Remove(p);
                db.SaveChanges();
            }
        }

        public List<Payment> Get()
        {
            return db.Payments.ToList();
        }

        public Payment GetById(int id)
        {
            return db.Payments.Where(p => p.Id == id).FirstOrDefault();
        }
        public List<Payment> GetByOrderId(int id)
        {
            return db.Payments.Where(p => p.OrderId == id).ToList();
        }

        public void Update(Payment entity)
        {
            var p = db.Payments.Where(p => p.Id == entity.Id).FirstOrDefault();
            if (p != null)
            {
                p.PayTime = entity.PayTime;
                p.PayType = entity.PayType;
                p.OrderId = entity.OrderId;
                p.Amount = entity.Amount;
                db.SaveChanges();
            }
        }
    }
}
