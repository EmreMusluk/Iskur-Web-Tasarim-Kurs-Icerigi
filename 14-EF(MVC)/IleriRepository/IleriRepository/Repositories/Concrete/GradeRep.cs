using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.Repositories.Concrete
{
    public class GradeRep<T> : BaseRepository<Grade>, IGradeRep
    {
        public GradeRep(MyContext db) : base(db)
        {
        }
    }
}
