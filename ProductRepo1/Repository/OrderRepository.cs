using ProductRepo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepo1.Repository
{
   public class OrderRepository : IRepository<Order>
    {
        ProductDBContext db = new ProductDBContext();
        public int Create(Order entity)
        {
            db.Orders.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }

        public void Delete(int id)
        {
            var p = db.Orders.Where(p => p.Id == id).FirstOrDefault();
            if(p != null)
            {
                p.Status = 0;
                db.SaveChanges();
            }
        }
        public void PermanentDelete(int id)
        {
            var p = db.Orders.Where(p => p.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.Orders.Remove(p);
                db.SaveChanges();
            }
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return db.Orders.Where(p => p.Id == id).FirstOrDefault();
        }
        public List<Order> GetByCustomerName(string name)
        {
            return db.Orders.Where(p => p.CustomerName.Contains(name)).ToList();
        }

        public void Update(Order entity)
        {
            var p = db.Orders.Where(p => p.Id == entity.Id).FirstOrDefault();
            if(p != null)
            {
                p.CustomerName = entity.CustomerName;
                p.Address = entity.Address;
                p.Price = entity.Price;
                p.OrderDate = entity.OrderDate;
                p.OrderDetails = entity.OrderDetails;
                p.Status = entity.Status;
                db.SaveChanges();
            }
        }
    }
}
