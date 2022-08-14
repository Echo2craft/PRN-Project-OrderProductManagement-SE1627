using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepo1
{
    interface IRepository<T> where T:class
    {
        int Create(T entity);
        void Delete(int id);
        void Update(T entity);
        T GetById(int id);
        List<T> Get();
    }
}
