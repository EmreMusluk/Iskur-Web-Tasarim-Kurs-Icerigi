using BasicRepository.Context;
using BasicRepository.Controllers;
using Microsoft.EntityFrameworkCore;

namespace BasicRepository.Repository
{
    //T herhangi bir tip gelebilir anlamındadır. where T : class T tipi sadece bir class olabilir.
    public class Repos<T> where T : class
    {
        MyContext db;
        public Repos(MyContext db)
        {
            this.db = db;
        }

        //geridönüş tipini List<T> dedik çünkü geriye herhangi bir classın listesini göndereceğiz.
        public List<T> List()
        {
            //Gönderilen t tipli classın listesini geri çevirdik.
            return Set().ToList();
        }
        //geridönüş tipini T dedik çünkü geriye sadece herhangi bir tip göndereceğiz.Product ya da Personel vs.
        public T Find(int Id)
        {
            return Set().Find(Id);
        }
        //Id hem int hem string olabileceğinden metot overloading yaptık.
        public T Find(string id)
        {
            return Set().Find(id);
        }
        public void Update(T entity)
        {
            Set().Update(entity);
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
                throw;
            }
        }
        public void Delete(T entity)
        {
            Set().Remove(entity);
        }
        public void Save()
        {
            db.SaveChanges();
        }

        //public void Delete(T entitiy)
        //{
        //    db.Set<T>().Remove(entitiy);
        //}
        // db.Set<T>() uzun uzun yazmak yerine onuda metot içerisinde yazdık.
        public DbSet<T> Set()
        {
            return db.Set<T>();
        }
    }
}
