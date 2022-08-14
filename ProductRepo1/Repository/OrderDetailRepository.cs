using ProductRepo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepo1.Repository
{
   public class OrderDetailRepository : IRepository<OrderDetail>
    {
        ProductDBContext db = new ProductDBContext();
        public int Create(OrderDetail entity)
        {
            db.OrderDetails.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }

        public void Delete(int id)
        {
            var p = db.OrderDetails.Where(p => p.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.OrderDetails.Remove(p);
                db.SaveChanges();
            }
        }

        public List<OrderDetail> Get()
        {
            return db.OrderDetails.ToList();
        }

        public OrderDetail GetById(int id)
        {
            return db.OrderDetails.Where(p => p.Id == id).FirstOrDefault();
        }
        public List<OrderDetail> GetByOrderId(int id)
        {
            return db.OrderDetails.Where(p => p.OrderId == id).ToList();
        }
        public List<OrderDetail> GetByProductId(int id)
        {
            return db.OrderDetails.Where(p => p.ProductId == id).ToList();
        }

        public void Update(OrderDetail entity)
        {
            var p = db.OrderDetails.Where(p => p.Id == entity.Id).FirstOrDefault();
            if (p != null)
            {
                p.OrderId = entity.OrderId;
                p.ProductId = entity.ProductId;
                p.Quantity = entity.Quantity;
                p.Price = entity.Price;
                db.SaveChanges();
            }
        }
    }
}
