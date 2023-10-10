using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;
using IleriRepository.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace IleriRepository.Repositories.Concrete
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep
    {
        public PersonelRep(MyContext db) : base(db)
        {

        }

        public Personel FindDetail(int Id)
        {
            //ThenInclude -- County içerisinde city olduğu için then dedik dıdısının dısı gibi :)
            return Set().Include(x => x.Department).Include(x => x.County).ThenInclude(x => x.City).FirstOrDefault(x => x.Id == Id);
        }

        public string FullName(Personel personel)
        {
            return personel.FullName(); ;
        }

        //public string FullName()
        //{
        //    return Set().Select(x => x.FullName()).ToString();
        //}

        public List<string> GetAddress(Personel personel)
        {
            return personel.GetAdress();
        }

        public int GetAge(Personel personel)
        {
            return personel.GetAge();
        }

        public List<PersonelDeparments> ListByDepartments()
        {
            //Select kolonları getirir.
            return Set().Select(x => new PersonelDeparments
            {
                Id = x.Id,
                Department = x.Department.DepartmentName,
                FullName = x.Name + " " + x.SurName,

            }).ToList();
        }

        public List<PersonelGrades> ListByGrades()
        {
            return Set().Select(x => new PersonelGrades
            {
                Grade = x.Grade.GradeName,
                FullName = x.Name + " " + x.SurName,
                Id = x.Id,
                GradeId = x.GradeId,
                ImgUrl = x.ImgUrl
            }).OrderBy(x => x.GradeId).ToList(); ;
        }
    }
}
