using Joole_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_Repository
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        protected JooleDBEntities1 db = new JooleDBEntities1();
        protected DbSet<T> entities;
        public Repository()
        {
            entities = db.Set<T>();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }

}
