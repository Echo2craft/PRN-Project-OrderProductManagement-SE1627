using ProductRepo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepo1.Repository
{
   public class ProductRepository : IRepository<Product>
    {
        ProductDBContext db = new ProductDBContext();
        public int Create(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }

        public void Delete(int id)
        {
            var p = db.Products.Where(p => p.Id == id).FirstOrDefault();
            if (p != null)
            {
                p.Status = 0;
                db.SaveChanges();

            }
        }

        public void PermanentDelete(int id)
        {
            var p = db.Products.Where(p => p.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.Products.Remove(p);
                db.SaveChanges();
            }
        }

        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.Where(p => p.Id == id).FirstOrDefault();
        }
        public List<Product> GetByName(string name)
        {
            return db.Products.Where(p => p.Name.Contains(name)).ToList();
        }

        public void Update(Product entity)
        {
            var p = db.Products.Where(p => p.Id == entity.Id).FirstOrDefault();
            if(p != null)
            {
                p.Name = entity.Name;
                p.Price = entity.Price;
                p.Status = entity.Status;
                p.CategoryId = entity.CategoryId;
                p.CreatedDate = entity.CreatedDate;
                db.SaveChanges();
            }
        }
    }
}
