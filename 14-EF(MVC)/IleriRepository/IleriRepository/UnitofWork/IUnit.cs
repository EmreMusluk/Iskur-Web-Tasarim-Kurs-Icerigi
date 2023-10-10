using IleriRepository.Repositories.Abstract;

namespace IleriRepository.UnitofWork
{
    public interface IUnit
    {
        IPersonelRep _personelRep { get; }
        IGradeRep _gradeRep { get; }
        ICountyRep _countyRep { get; }
        IDepartmentRep _departmentRep { get; }
        ICityRep _cityRep { get; }
        void Commit();

    }
}
