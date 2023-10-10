using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Core
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> List();
        T Find(int Id);
        T Find(string Id);
        bool Update(T entity);
        bool Delete(int Id);
        bool Delete(string Id);
        bool Add(T entity);
        DbSet<T> Set();
    }
}
