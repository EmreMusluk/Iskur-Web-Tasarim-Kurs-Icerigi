using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;

namespace IleriRepository.Repositories.Abstract
{
    public interface IPersonelRep : IBaseRepository<Personel>
    {
        List<PersonelGrades> ListByGrades();
        List<PersonelDeparments> ListByDepartments();
        int GetAge(Personel personel);
        List<string> GetAddress(Personel personel);
        string FullName(Personel personel);
        Personel FindDetail(int Id);
    }
}