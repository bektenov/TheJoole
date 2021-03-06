using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Remove(T entity);
        void SaveChanges();

    }
}
