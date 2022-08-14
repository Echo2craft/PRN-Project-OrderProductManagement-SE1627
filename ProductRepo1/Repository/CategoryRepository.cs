using ProductRepo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepo1.Repository
{
   public class CategoryRepository : IRepository<Category>
    {
        ProductDBContext db = new ProductDBContext();
        public int Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }

        public void Delete(int id)
        {
            var p = db.Categories.Where(p => p.Id == id).FirstOrDefault();
            if(p != null)
            {
                p.Status = 0;
                db.SaveChanges();
            }
        }
        public void PermanentDelete(int id)
        {
            var p = db.Categories.Where(p => p.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.Categories.Remove(p);
                db.SaveChanges();
            }
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Where(p => p.Id == id).FirstOrDefault();
        }
        public List<Category> GetByName(string name)
        {
            return db.Categories.Where(p => p.Name.Contains(name)).ToList();
        }

        public void Update(Category entity)
        {
            var p = db.Categories.Where(p => p.Id == entity.Id).FirstOrDefault();
            if (p != null)
            {
                p.Name = entity.Name;
                p.Products = entity.Products;
                p.Status = entity.Status;
                db.SaveChanges();
            }
        }
    }
}
