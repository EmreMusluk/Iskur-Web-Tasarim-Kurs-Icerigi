using IleriRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace IleriRepository.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        MyContext db;
        public BaseRepository(MyContext db)
        {
            this.db = db;
        }
        public bool Add(T entity)
        {
            try
            {
                Set().Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                Set().Remove(Find(Id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string Id)
        {
            try
            {
                Set().Remove(Find(Id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);
        }
        public T Find(string id)
        {
            return Set().Find(id);
        }

        public List<T> List()
        {
            return Set().ToList();
        }
        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public bool Update(T entity)
        {
            try
            {
                Set().Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
