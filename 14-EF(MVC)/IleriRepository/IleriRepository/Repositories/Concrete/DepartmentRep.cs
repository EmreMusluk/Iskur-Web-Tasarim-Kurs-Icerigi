using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.Repositories.Concrete
{
    public class DepartmentRep<T> : BaseRepository<Department>, IDepartmentRep
    {
        public DepartmentRep(MyContext db) : base(db)
        {
        }
    }
}
