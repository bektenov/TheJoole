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
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            db.SaveChanges();
        }

        public T Get(long id)
        {
            T entity = entities.Find(id);
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            db.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

}
