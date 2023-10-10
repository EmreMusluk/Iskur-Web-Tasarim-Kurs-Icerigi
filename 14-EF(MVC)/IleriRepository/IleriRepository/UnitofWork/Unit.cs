using IleriRepository.Context;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.UnitofWork
{
    public class Unit : IUnit
    {
        MyContext _db;
        public IPersonelRep _personelRep { get; private set; }

        public IGradeRep _gradeRep { get; private set; }

        public ICountyRep _countyRep { get; private set; }

        public IDepartmentRep _departmentRep { get; private set; }

        public ICityRep _cityRep { get; private set; }
        //Program.cs de yazdığımız kod sayesinde ctordaki ICityRep yazsakta aslında cityrep newlenir.
        //                                                                                                                          CityRep cityRep = new CityRep();                                                                 
        public Unit(MyContext db, IPersonelRep personelRep, IGradeRep gradeRep, ICountyRep countyRep, IDepartmentRep departmentRep, ICityRep cityRep)
        {
            _db = db;
            _personelRep = personelRep;
            _gradeRep = gradeRep;
            _countyRep = countyRep;
            _departmentRep = departmentRep;
            _cityRep = cityRep;
        }
        public void Commit()
        {
            _db.SaveChanges();
        }

    }
}
